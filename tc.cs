using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Liberary_management_system
{
    public partial class tc : Form
    {
        public tc()
        {
            InitializeComponent();
        }

        private void tc_Load(object sender, EventArgs e)
        {
            richTextBox1.Text = "Terms and Conditions (Terms)  \n==============================\nLast updated: February 23, 2019\n\nPlease read these Terms and Conditions (Terms, Terms and Conditions)carefully before using the Liberary management system (the Service) operated by (us, we, or , our). Your access to and use of the Service is conditioned on your acceptance of and compliance with these Terms. These Terms apply to all visitors, users and others who access or use the Service. By accessing or using the Service you agree to be bound by these Terms. If you disagree with any part of the terms then you may not access the Service. The Terms and Conditions agreement has been created with the help of [TermsFeed](www.termsfeed.com/)\nAccounts  -------- When you create an account with us, you must provide us information that is accurate, complete, and current at all times. Failure to do so constitutes a breach of the Terms, which may result in immediate termination of your account on our Service. You are responsible for safeguarding the password that you use to access the Service and for any activities or actions under your password, whether your password is with our Service or a third-party service. You agree not to disclose your password to any third party. You must notify us immediately upon becoming aware of any breach of security or unauthorized use of your account.\nLinks To Other Web Sites  ------------------------ Our Service may contain links to third-party web sites or services that are not owned or controlled by . has no control over, and assumes no responsibility for, the content, privacy policies, or practices of any third party web sites or services. You further acknowledge and agree that shall not be responsible or liable, directly or indirectly, for any damage or loss caused or alleged to be caused by or in connection with use of or reliance on any such content, goods or services available on or through any such web sites or services. We strongly advise you to read the terms and conditions and privacy policies of any third-party web sites or services that you visit.\nTermination  -----------We may terminate or suspend access to our Service immediately, without prior notice or liability, for any reason whatsoever, including without limitation if you breach the Terms. All provisions of the Terms which by their nature should survive termination shall survive termination, including, without limitation, ownership provisions, warranty disclaimers, indemnity and limitations of liability. We may terminate or suspend your account immediately, without prior notice or liability, for any reason whatsoever, including without limitation if you breach the Terms. Upon termination, your right to use the Service will immediately cease. If you wish to terminate your account, you may simply discontinue using the Service. All provisions of  the Terms which by their nature should survive termination shall survive termination, including, without limitation, ownership provisions, warranty disclaimers, indemnity and limitations of liability.\nGoverning Law ------------- These Terms shall be governed and construed in accordance with the laws of Pakistan, without regard to its conflict of law provisions.Our failure to enforce any  right or provision of these Terms will not be considered a waiver of those rights. If any provision of these Terms is held to be invalid or unenforceable by a court, the remaining provisions of  these Terms will remain in effect. These Terms constitute the entire agreement between us regarding our Service, and supersede and replace any prior agreements we might have between us regarding the Service.\nChanges ------- We reserve the right, at our sole discretion, to modify or replace these Terms at any time. If a revision is material we will try to provide at least 30 days notice prior to any new terms taking effect. What constitutes a material change will be determined at our sole discretion. By continuing to access or use our Service after those revisions become effective, you agree to be bound by the revised terms. If you do not agree to the new terms, please stop using the Service.\nContact Us  ---------- 0300-2507605 0r +1(202)9719510 If you have any questions about these Terms, please contact us.";
            richTextBox1.Enabled = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 f1 = new Form1();
            f1.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
