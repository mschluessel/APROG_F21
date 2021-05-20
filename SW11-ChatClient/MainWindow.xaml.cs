using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using ChatClientLib;

namespace SW11_ChatClient {
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window {

        private IChatClient client;

        List<string> listReceivedMessages = new List<string>();
        List<string> listChatUsers = new List<string>();

        public MainWindow() {
            InitializeComponent();

            ListBoxReceivedMessages.ItemsSource = listReceivedMessages;
            ListBoxChatUsers.ItemsSource = listChatUsers;

        }

        private void ButtonLoginClick(object sender, RoutedEventArgs e) {
            string name = TextBoxName.Text;
            string host = TextBoxHost.Text;
            client = new ChatClientTcp(host);
            client.MessageReceived += Client_MessageReceived;
            client.UserUpdate += Client_UserUpdate;
            Thread.Sleep(500);
            client.Login(name);
        }

        private void Client_UserUpdate(object sender, UserUpdateEventArgs e) {
            object o = ListBoxChatUsers.SelectedItem;
            string[] newUser = e.Users;
            //listChatUsers.Add(newUser);
            listChatUsers = newUser.ToList();
            this.Dispatcher.Invoke(() => {
                ListBoxChatUsers.Items.Clear();
                foreach (string user in newUser) {
                    listChatUsers.Add(user);
                    }
                ListBoxChatUsers.Items.Refresh();
                ListBoxChatUsers.SelectedItem = o;
            });
        }

        private void Client_MessageReceived(object sender, MessageReceivedEventArgs e) {
            string msg = e.Message;
            listReceivedMessages.Add(msg);
            this.Dispatcher.Invoke(() =>
            {
                ListBoxReceivedMessages.Items.Refresh();
            });
            
        }

        private void ButtonSendMessage(object sender, RoutedEventArgs e) {
            string message = TextBoxMessageToSend.Text;
            client.SendMessage("spam-bot", message);
        }

        
    }
}
