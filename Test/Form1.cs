using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using System.Xml.XPath;
using System.IO;


namespace Test
{

    public partial class Form1 : Form
    {

        //Init the App, Loop Read XML function can be put in here.
        public Form1()
        {
            
            InitializeComponent();
            InitData();
            //LoadAnim.ShowSync(this, false, null);
        }

        public void InitData()
        {
            if (File.Exists("todo.xml"))
            {
                XmlDocument doc = new XmlDocument();
                doc.Load("todo.xml");
                XmlElement root = doc.DocumentElement;
                XmlNodeList nodes = root.GetElementsByTagName("Item");
                foreach (XmlNode node in nodes)
                {
                    AddItem(node.Attributes["item_id"].Value, node.Attributes["item_name"].Value, bool.Parse(node.Attributes["status"].Value));
                }
            }
        }


        // Function for counting Item, used to set ID
        public String GetCounter()
        {
            if (File.Exists("todo.xml"))
            {
                XmlDocument xmlD = new XmlDocument();
                xmlD.Load("todo.xml");
                XmlNodeList xmlNL = xmlD.GetElementsByTagName("Item");
                int counter = xmlNL.Count;
                return (counter+1).ToString();
            }
            return "1";
        }
    
        public Point Point = new Point(0, 0); //Create a new Point, used to location the user_controller

        public void AddItem(String index, String Text, bool Checked)
        {
            todo_item item = new todo_item(index, Text, Checked);
            item.Name = index;
            item.Location = new Point(0, 10 + mainPanel.AutoScrollPosition.Y + Point.Y);
            Point.Y += item.Size.Height + 10;
            mainPanel.Controls.Add(item);
            item.GetIndex();
            //item.OnChange += item_OnChange;
            //item.OnDelete += item_OnDelete;
        }

        //private void item_OnChange(object sender, EventArgs e)
        //{
        //    MessageBox.Show("Change Test");
        //}

        private void addItem_Click(object sender, EventArgs e)
        {
            if(input_text.Text != "")
            {
                AddItem(GetCounter(), input_text.Text, false);
                if (File.Exists("todo.xml"))
                {
                    XmlDocument doc = new XmlDocument();
                    doc.Load("todo.xml");
                    XmlNode node = doc.SelectSingleNode("//Todo_List");
                    XmlNode itemNode = doc.CreateElement("Item");
                    itemNode.Attributes.Append(CreateAttribute(node, "item_id", GetCounter()));
                    itemNode.Attributes.Append(CreateAttribute(node, "item_name", input_text.Text));
                    itemNode.Attributes.Append(CreateAttribute(node, "status", "false"));
                    node.AppendChild(itemNode);
                    doc.Save("todo.xml");  //Save the xml

                }
                else
                {
                    XmlDocument doc = new XmlDocument();
                    XmlDeclaration dec = doc.CreateXmlDeclaration("1.0", "utf-8", null);
                    doc.AppendChild(dec);
                    //create the root element
                    XmlElement root = doc.CreateElement("Todo_App");
                    doc.AppendChild(root);
                    //create the "Todo_List" element
                    XmlElement element = doc.CreateElement("Todo_List");
                    root.AppendChild(element);

                    //create the "Item" element with attributes
                    XmlNode node = doc.CreateElement("Item");
                    node.Attributes.Append(CreateAttribute(node, "item_id", "1"));
                    node.Attributes.Append(CreateAttribute(node, "item_name", input_text.Text));
                    node.Attributes.Append(CreateAttribute(node, "status", "false"));
                    root.ChildNodes[0].AppendChild(node);

                    doc.Save("todo.xml");
                    //MessageBox.Show("XML File created ! ");

                }
            }

            input_text.Text = "";
        }

        public XmlAttribute CreateAttribute(XmlNode node, string attributeName, string value)
        {
            try
            {
                XmlDocument doc = node.OwnerDocument;
                XmlAttribute attr = null;
                attr = doc.CreateAttribute(attributeName);
                attr.Value = value;
                node.Attributes.SetNamedItem(attr);
                return attr;
            }
            catch (Exception err)
            {
                string desc = err.Message;
                return null;
            }
        }

        private void ExitApp_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void ClearAll_Click(object sender, EventArgs e)
        {
            XmlDocument doc = new XmlDocument();
            doc.Load("todo.xml");
            string path = "//Todo_List";
            XmlNode node = doc.SelectSingleNode(path);
            //XmlNode root = doc.DocumentElement;
            node.RemoveAll();
            doc.Save("todo.xml");
            mainPanel.Controls.Clear();
        }
    }
}
