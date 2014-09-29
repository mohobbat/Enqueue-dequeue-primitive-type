using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MyEnqueueAndDqueueApp
{
    public partial class EnqueueDequeAppUI : Form
    {
        public EnqueueDequeAppUI()
        {
            InitializeComponent();
        }

        private string name;
        private string complain;
        private int serialNo = 1;

        private Queue<string>myQueue=new Queue<string>();
        private ListViewItem detail=new ListViewItem();
        private void enqueueButton_Click(object sender, EventArgs e)
        {

            name = nameEnqueueTextBox.Text;
            complain = complainEnqueueTextBox.Text;
            
            myQueue.Enqueue(Convert.ToString(serialNo));
            myQueue.Enqueue(name);
            myQueue.Enqueue(complain);

           // detail=new ListViewItem();

            detail.Text = Convert.ToString(serialNo);
            detail.SubItems.Add(name);
            detail.SubItems.Add(complain);

            waitingQueueListView.Items.Add(detail);

            serialNo++;

        }

        private void deQueueButton_Click(object sender, EventArgs e)
        {
            if (myQueue.Count == 0)
            {
                MessageBox.Show("Quqeue is Empty");
            }

            else
            {
                serialNoDequeueTextBox.Text = myQueue.Dequeue();
                nameDequeueTextBox.Text = myQueue.Dequeue();
                complainDequeueTextBox.Text = myQueue.Dequeue();

                waitingQueueListView.Items[0].Remove();
            }

        }
    }
}
