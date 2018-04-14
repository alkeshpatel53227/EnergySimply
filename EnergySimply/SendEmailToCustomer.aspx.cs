using EnergySimplyLib.ServiceDal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace EnergySimply
{
    public partial class SendEmailToCustomer : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                divSuccess.Visible = false;
                divError.Visible = false;
                divEmail.Visible = true;
                divPreview.Visible = false;
                CustomerDal dal = new CustomerDal();
                ddlCustomer.DataSource = dal.GetAllCustomers();
                ddlCustomer.DataBind();
            }
        }

        protected void btnPreview_Click(object sender, EventArgs e)
        {
            divError.Visible = false;
            divSuccess.Visible = false;
            if (!string.IsNullOrEmpty(txtSubject.Text) && !string.IsNullOrEmpty(txtMessage.Text))
            {
                divPreview.Visible = true;
                CustomerDal dal = new CustomerDal();
                var customer = dal.GetCustomerById(int.Parse(ddlCustomer.SelectedValue));
                lblPreviewTo.Text = customer.CustomerEmail;
                lblSubject.Text = txtSubject.Text;
                lblMsg.Text = txtMessage.Text;
                divEmail.Visible = false;
            }
            else
            {
                divError.Visible = true;
                divErrorMsg.InnerHtml = "<h3>Please enter all the fields!</h3>";
            }
           
            
        }

        protected void btnBack_Click(object sender, EventArgs e)
        {
            divEmail.Visible = true;
            divPreview.Visible = false;
            divSuccess.Visible = false;
            divError.Visible = false;

        }

        protected void btnSend_Click(object sender, EventArgs e)
        {
            try
            {
                divSuccess.Visible = false;
                divError.Visible = false;
                
                // this part is taken from @hrvoje-hudo response, thanks to him !
                var mail = new MailMessage();
                SmtpClient client = new SmtpClient("mail.alkesh-patel.com");

                mail.From = new MailAddress("postmaster@alkesh-patel.com");

                mail.To.Add(lblPreviewTo.Text);

                mail.Subject = lblSubject.Text;

                // Here you define your message
                mail.Body = lblMsg.Text;
                
                client.Port = 587;
                client.Credentials = new System.Net.NetworkCredential("postmaster@alkesh-patel.com", "Yug$2002");
                //client.EnableSsl = true;

                client.Send(mail);
                divSuccess.Visible = true;
                divError.Visible = false;
                divPreview.Visible = false;
                divEmail.Visible = true;
                txtMessage.Text = "";
                txtSubject.Text = "";

            }
            catch (SmtpFailedRecipientException ex)
            {
                divError.Visible = true;
                divErrorMsg.InnerHtml = "<h3>There was a problem in sending email. Please if customer email is valid!</h3>";
            }
            catch (Exception ex)
            {
                divError.Visible = true;
                divErrorMsg.InnerHtml = "<h3>There was a problem in sending email. Please if customer email is valid!</h3>";
            }
        }
    }
}