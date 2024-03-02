using Protowire;
using System.Diagnostics;
using Grpc.Core;
using static Protowire.RPC;
using Google.Protobuf.WellKnownTypes;
using FluentEmail.Core;
using FluentEmail.Razor;
using FluentEmail.Smtp;
using System.Net.Mail;
using System.Net;
using System.Text;

namespace Sendmailkas
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void llCheck_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            BalanceCheck(txtAddress.Text);
        }

        private async void BalanceCheck(string strAdress)
        {
            string strConn = "http://" + txtIP.Text + ":" + txtPort.Text;
            KasClient kc = new KasClient(strConn);
            using var messageStream = kc.Client.MessageStream();
            double dBalance = 0;
            //messageStream.
            //kc.Client.

            KaspadMessage getUTXOsRequest = new KaspadMessage
            {
                GetUtxosByAddressesRequest = new GetUtxosByAddressesRequestMessage
                {
                    Addresses = { strAdress } // change this to your address
                                              //             Addresses = { "kaspa:qq8vljkccder84lnch6je68z426smzs8are6060535e50dmg9dzl6xuznrf53" } // change this to your address
                }
            };

            await messageStream.RequestStream.WriteAsync(getUTXOsRequest);
            await messageStream.ResponseStream.MoveNext();
            var response = messageStream.ResponseStream.Current;

            Trace.WriteLine("UTXOs by address:");
            ulong nTotal = 0;
            foreach (UtxosByAddressesEntry ab in response.GetUtxosByAddressesResponse.Entries)
            {
                Trace.WriteLine(ab.ToString());
                Trace.WriteLine(ab.Address);
                nTotal += ab.UtxoEntry.Amount;
            }
            dBalance = nTotal / 100000000.0;
            Trace.WriteLine("×ÜÓà¶î£º" + dBalance);

            txtBalance.Text = string.Format("{0:F8}", dBalance); //dBalance.ToString();
        }

        private void llSend_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            SendMail();
        }

        private async void SendMail()
        {
            string strAddressFrom = txtAddress.Text.Replace("kaspa:", "kaspa_") + "@mailkas.com";
            var fromAddress = new MailAddress(strAddressFrom, txtAddress.Text);
            var fromPassword = txtPwdFrom.Text;
            string strAddressTo = txtAddressTo.Text.Replace("kaspa:", "kaspa_") + "@mailkas.com";
            var toAddress = new MailAddress(strAddressTo);

            var sender = new SmtpSender(() => new SmtpClient("localhost")
            {
                EnableSsl = false,
                Host = "mailkas.com",
                Port = 25,
                DeliveryMethod = SmtpDeliveryMethod.Network,
                UseDefaultCredentials = false,
                Credentials = new NetworkCredential(fromAddress.Address, fromPassword)
            }); ;

            StringBuilder template = new();
            template.AppendLine(strAddressFrom);
            template.AppendLine("<p> <b>support@mailkas.com</b>. Mail from one kaspa to another kaspa.</p>");
            template.AppendLine("<br/>");
            template.AppendLine("mailkas");


            Email.DefaultSender = sender;
            Email.DefaultRenderer = new RazorRenderer();

            var email = await Email.From(fromAddress.Address, fromAddress.DisplayName)
                                   .To(strAddressTo)
                                   .Subject("Email from " + txtAddress.Text)
                                   .UsingTemplate(template.ToString(), new { FirstName = "Eliseo", ProductName = "Latis/Pro" })
                                   .Body(txtMail.Text)
                                   .SendAsync();

            if (email.Successful)
                lblInfo.Text = "Mail is sent successful!";
            else
                lblInfo.Text = "Mail failed!";
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
        }
    }
}