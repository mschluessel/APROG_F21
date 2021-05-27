using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
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
using System.Threading;

namespace SW11_ChatClientV2 {
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window {


        private IChatClient client;

        //List<string> listReceivedMessages = new List<string>();
        //List<string> listChatUsers = new List<string>();

        public MainWindow() {
            InitializeComponent();

            //ListBoxReceivedMessages.ItemsSource = listReceivedMessages;
            //ListBoxChatUsers.ItemsSource = listChatUsers;

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
            string[] newUser = e.Users;
            //listChatUsers.Add(newUser);
            //listChatUsers.Clear();
            //listChatUsers = newUser.ToList();
            this.Dispatcher.Invoke(() => {
                object o = ListBoxChatUsers.SelectedItem;
                ListBoxChatUsers.Items.Clear();
                foreach (string user in newUser) {
                    ListBoxChatUsers.Items.Add(user);
                }
                //ListBoxChatUsers.Items.Refresh();
                if (o != null) ListBoxChatUsers.SelectedItem = o;
            });
        }

        private void Client_MessageReceived(object sender, MessageReceivedEventArgs e) {
            string msg = e.Message;
            //listReceivedMessages.Add(msg);
            this.Dispatcher.Invoke(() => {
                ListBoxReceivedMessages.Items.Add(msg);
                //ListBoxReceivedMessages.Items.Refresh();
            });

        }

        private void ButtonSendMessage(object sender, RoutedEventArgs e) {
            string message = TextBoxMessageToSend.Text;
            string receiver = ListBoxChatUsers.SelectedItem.ToString();
            client.SendMessage(receiver, message);
        }

        private void ListBoxChatUsers_SelectionChanged(object sender, SelectionChangedEventArgs e) {

        }

        private void MessageBoxKeyDown(object sender, KeyEventArgs e) {
            if (e == Key.Enter()) {

            }
        }

        //private void WindowClose(object sender, System.ComponentModel.CancelEventArgs e) {
        //    client.Disconnect();
        //}

    }
}
