using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using Newtonsoft.Json;
using System.Net.Http;
using System.Windows.Forms;
using Wechat;
namespace WechatBot
{
    public partial class WechatBot : Form
    {

        WxClient wx = new WxClient();
        public WechatBot()
        {
            InitializeComponent();
        }

        private void WechatBot_Load(object sender, EventArgs e)
        {
            wx.OnEvent += OnWxEvent;
            wx.Run();
        }
        List<string> groups = new List<string>();
        private void OnWxEvent(WxClient sender, WeChatClientEvent e)
        {

            

            RunInMainthread(()=> {
                log(e.ToString());
                if (e is GetQRCodeImageEvent)
                {
                    var qrEvent = e as GetQRCodeImageEvent;
                    pictureBox_qrcode.Image = qrEvent.QRImage;
                    label_tips.Text = "用手机微信扫码登陆";
                }
                if (e is UserScanQRCodeEvent)
                {
                    var scanedQrEvent = e as UserScanQRCodeEvent;
                    pictureBox_qrcode.Image = scanedQrEvent.UserAvatarImage;
                    label_tips.Text = "在手机上确认以登陆";
                }
                if (e is LoginSucessEvent)
                {
                    var loginEvent = e as LoginSucessEvent;
                    label_tips.Text = "登陆成功,正在同步消息...";
                }
                if (e is InitedEvent)
                {
                    var eve = e as InitedEvent;
                    label_tips.Text = string.Format( "[{0}]微信机器人正在运行中...",wx.Self.NickName);
                    wx.SendMsg(wx.Self.ID, "图灵机器人启动了");
                }
                if (e is AddMessageEvent)
                {
                    var msgEvent = e as AddMessageEvent;
                    if (msgEvent.Msg is TextMessage) {
                        var msg = msgEvent.Msg as TextMessage;

                        if (msg.Content == "老王")
                        {
                            if (!groups.Contains(msg.ToContactD)) {
                                groups.Add(msg.ToContactD);
                                wx.SendMsg(msg.ToContactD, "[老王]我在呢");
                                return;
                            }
                            
                 
                        }
                        if (msg.Content == "老王 退下吧")
                        {
                            if (groups.Contains(msg.ToContactD))
                            {
                                groups.Remove(msg.ToContactD);
                                wx.SendMsg(msg.ToContactD, "[老王]好,我退下了");
                                return;
                            }
                            
                            
                        }
                        if ((msg.ToContactD == wx.Self.ID || groups.Contains(msg.ToContactD)) && !msg.Content.StartsWith("[老王]")) {

                            string uid = msg.FromContactID.Remove(0, 2);
                            if (uid.Length > 32)
                            {
                                uid = uid.Substring(0, 32);
                            }
                            var info = msg.Content;
                            string rep = tulingBot(info, uid);
                            if (msg.ToContactD.StartsWith("@@"))
                            {
                                wx.SendMsg(msg.ToContactD, "[老王]" + rep);
                            }
                            else if (msg.ToContactD.StartsWith("@"))
                            {
                                wx.SendMsg(msg.FromContactID, "[老王]" + rep);
                            }
                            else {
                                wx.SendMsg(msg.ToContactD, "[老王]" + rep);
                            }
                           
                            log("[收到消息]" + info);
                            log("[老王]" + rep);
                        }
                    }
                }
            });
        }


        void RunInMainthread(Action action)
        {
            this.BeginInvoke((Action)(delegate ()
            {
                action?.Invoke();
            }));
        }

        void log(string str)
        {
            string log_str = string.Format("#{0}:{1}\r\n", DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"),str);
            textBox_log.AppendText(log_str);
        }


        string tulingBot(string info, string userid)
        {

            BotRequest req = new BotRequest();
            req.key = "cb85047a815e418eb334263af2f9830a";
            req.userid = userid;
            req.info = info;
            string json = JsonConvert.SerializeObject(req);

            string url = "http://www.tuling123.com/openapi/api";
            HttpClient httpClient = new HttpClient();
            HttpResponseMessage response = httpClient.PostAsync(new Uri(url), new StringContent(json)).Result;
            string ret = response.Content.ReadAsStringAsync().Result;
            var rep = JsonConvert.DeserializeObject<BotResponse>(ret);
            return rep.text;
        }

        private void WechatBot_FormClosed(object sender, FormClosedEventArgs e)
        {
            wx.Quit();
        }
    }
}


public class BotRequest
{
    public string key;
    public string info;
    public string userid;
}

public class BotResponse
{
    public string code;
    public string text;
    public string url;
}
