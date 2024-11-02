//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;
//using System.Windows.Forms;

//namespace GUI_Lec1
//{
//    internal class myForm:Form
//    {
//        private Label label1;
//        private Button btnClickMe;

//        public myForm()
//        {

           
//            this.Text = "First GUI";


//            Button btnClickMe = new Button();
//            btnClickMe.Text = "Click Me";
//            btnClickMe.Click += new EventHandler(btn_ClickMe_event);
//            this.Controls.Add(btnClickMe);


//            Label label = new Label();
//            label.Text = "hello" +
//                "This is a testing label" +
//                "To see where it will be shown";
//            this.Controls.Add(label);

//        }
//        public  void btn_ClickMe_event(object obj, EventArgs args)
//        {
//            MessageBox.Show("Welcome to my First GUI lec");
//        }

       

//        private void btnClickMe_Click(object sender, EventArgs e)
//        {

//            MessageBox.Show("Welcome to Win form application");
//        }
//    }
//}
