using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using System.Xml.XPath;
using System.IO;

namespace Test
{
    public partial class todo_item : UserControl
    {
        private String index;
        public todo_item()
        {
            InitializeComponent();
        }

        public todo_item(String index, String inputText, bool isChecked)
        {
            this.index = index;
            InitializeComponent();
            todo_text.Text = inputText;
            checkButton.Checked = isChecked;
        }

        public String GetIndex()
        {
            return index;
        }

        //public event EventHandler OnChange = null;

        //public event EventHandler OnDelete = null;


        private void checkButton_OnChange(object sender, EventArgs e)
        {
            if(checkButton.Checked)
            {
                todo_text.Font = new Font(todo_text.Font.Name, todo_text.Font.SizeInPoints, FontStyle.Strikeout);
                XmlDocument doc = new XmlDocument();
                doc.Load("todo.xml");
                string path = "//Item[@item_id=" + GetIndex() + "]";
                XmlNode node = doc.SelectSingleNode(path);
                if (node != null)
                {
                    node.Attributes["status"].Value = "true";  //The status will be shown in the Name box
                }
                doc.Save("todo.xml");

            }
            else
            {
                todo_text.Font = new Font(todo_text.Font.Name, todo_text.Font.SizeInPoints, FontStyle.Regular);
                XmlDocument doc = new XmlDocument();
                doc.Load("todo.xml");
                string path = "//Item[@item_id=" + GetIndex() + "]";
                XmlNode node = doc.SelectSingleNode(path);
                if (node != null)
                {
                    node.Attributes["status"].Value = "false";  //The status will be shown in the Name box
                }
                doc.Save("todo.xml");
            }
            //if (OnChange != null)
            //{
            //    OnChange.Invoke(this, new EventArgs());
            //}
        }

        private void todo_item_Load(object sender, EventArgs e)
        {
            if (checkButton.Checked)
            {
                todo_text.Font = new Font(todo_text.Font.Name, todo_text.Font.SizeInPoints, FontStyle.Strikeout);
            }
            else
            {
                todo_text.Font = new Font(todo_text.Font.Name, todo_text.Font.SizeInPoints, FontStyle.Regular);
            }
        }
    }
}
