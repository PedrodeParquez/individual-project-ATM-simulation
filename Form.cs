using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Media;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ToolBar;

namespace SimulationATM {
  public partial class Form : System.Windows.Forms.Form {

    [DllImport("user32.dll")]
    private static extern bool HideCaret(IntPtr hWnd);

    private void playSound () {
      SoundPlayer Sound = new SoundPlayer("C:\\Users\\Егор\\Downloads\\sound.wav");
      Sound.Play();
    }

    private void playBeep () {
      SoundPlayer player = new SoundPlayer("C:\\Users\\Егор\\Downloads\\beep.wav");
      player.Play();
    }
    int NumberOfAttempts = 0;

    public Form() {
      InitializeComponent();
    }

    private void Form_Load_1(object sender, EventArgs e) {
      playSound();

      // Textbox cо временем на главном экране
      int updateInterval = 1000;
      System.Windows.Forms.Timer timer = new System.Windows.Forms.Timer();
      timer.Interval = updateInterval;
      timer.Tick += Timer_Tick;
      timer.Start();

      //Начальный настройки пользователя 
      сard_Balance.Text = BankCard.BalanceCard.ToString() + " ₽";
      сard_Balance.ReadOnly = true;
      Welcome_And_Name_Field.Text = " Здравствуйте, " + BankCard.OwnersName;
      Home_Screen.Visible = true;

      // Дизайн кнопок и TextBox
      Color redBackgroundColor = Color.FromArgb((0xC92F2F >> 16) & 0xFF, (0xC92F2F >> 8) & 0xFF, 0xC92F2F & 0xFF);
      Color yellowBackgroundColor = Color.FromArgb(0xE4, 0xC8, 0x65);

      PIN_Code.KeyPress += PIN_Code_KeyPress;
      PIN_Code.BackColor = redBackgroundColor;
      Cash_Withdrawal_Field.BackColor = redBackgroundColor;  
      Cash_Deposit_Field.BackColor = redBackgroundColor;
      сard_Balance.BackColor = redBackgroundColor;
      Time_And_Date_Field.BackColor = redBackgroundColor;
      Welcome_And_Name_Field.BackColor = yellowBackgroundColor;
    }

    /* Кнопки на корпусе банкомата
    
    Цифровая клавитура*/

    private void button_One(object sender, EventArgs e) {
      playBeep();

      if (PIN_Code_Screen.Visible == true) {
        PIN_Code.Text += "1";
      } else if (Cash_Deposit_Screen.Visible == true) {
        Cash_Deposit_Field.Text += "1";
      } else if (Cash_Withdrawal_Screen.Visible == true) {
        Cash_Withdrawal_Field.Text += "1";
      }

    }
    private void button_Two(object sender, EventArgs e) {
      playBeep();

      if (PIN_Code_Screen.Visible == true) {
        PIN_Code.Text += "2";
      } else if (Cash_Deposit_Screen.Visible == true) {
        Cash_Deposit_Field.Text += "2";
      } else if (Cash_Withdrawal_Screen.Visible == true) {
        Cash_Withdrawal_Field.Text += "2";
      }
    }

    private void button_Three(object sender, EventArgs e) {
      playBeep();

      if (PIN_Code_Screen.Visible == true) {
        PIN_Code.Text += "3";
      } else if (Cash_Deposit_Screen.Visible == true) {
        Cash_Deposit_Field.Text += "3";
      } else if (Cash_Withdrawal_Screen.Visible == true) {
        Cash_Withdrawal_Field.Text += "3";
      }
    }

    private void button_Four(object sender, EventArgs e) {
      playBeep();

      if (PIN_Code_Screen.Visible == true) {
        PIN_Code.Text += "4";
      } else if (Cash_Deposit_Screen.Visible == true) {
        Cash_Deposit_Field.Text += "4";
      } else if (Cash_Withdrawal_Screen.Visible == true) {
        Cash_Withdrawal_Field.Text += "4";
      }
    }

    private void button_Five(object sender, EventArgs e) {
      playBeep();

      if (PIN_Code_Screen.Visible == true) {
        PIN_Code.Text += "5";
      } else if (Cash_Deposit_Screen.Visible == true) {
        Cash_Deposit_Field.Text += "5";
      } else if (Cash_Withdrawal_Screen.Visible == true) {
        Cash_Withdrawal_Field.Text += "5";
      }
    }

    private void button_Six(object sender, EventArgs e) {
      playBeep();

      if (PIN_Code_Screen.Visible == true) {
        PIN_Code.Text += "6";
      } else if (Cash_Deposit_Screen.Visible == true) {
        Cash_Deposit_Field.Text += "6";
      } else if (Cash_Withdrawal_Screen.Visible == true) {
        Cash_Withdrawal_Field.Text += "6";
      }
    }

    private void button_Seven(object sender, EventArgs e) {
      playBeep();

      if (PIN_Code_Screen.Visible == true) {
        PIN_Code.Text += "7";
      } else if (Cash_Deposit_Screen.Visible == true) {
        Cash_Deposit_Field.Text += "7";
      } else if (Cash_Withdrawal_Screen.Visible == true) {
        Cash_Withdrawal_Field.Text += "7";
      }
    }

    private void button_Eight(object sender, EventArgs e) {
      playBeep();

      if (PIN_Code_Screen.Visible == true) {
        PIN_Code.Text += "8";
      } else if (Cash_Deposit_Screen.Visible == true) {
        Cash_Deposit_Field.Text += "8";
      } else if (Cash_Withdrawal_Screen.Visible == true) {
        Cash_Withdrawal_Field.Text += "8";
      }
    }
    private void button_Nine(object sender, EventArgs e) {
      playBeep();

      if (PIN_Code_Screen.Visible == true) {
        PIN_Code.Text += "9";
      } else if (Cash_Deposit_Screen.Visible == true) {
        Cash_Deposit_Field.Text += "9";
      } else if (Cash_Withdrawal_Screen.Visible == true) {
        Cash_Withdrawal_Field.Text += "9";
      }
    }

    private void button_Zero(object sender, EventArgs e) {
      playBeep();

      if (PIN_Code_Screen.Visible == true) {
        PIN_Code.Text += "0";
      } else if (Cash_Deposit_Screen.Visible == true) {
        Cash_Deposit_Field.Text += "0";
      } else if (Cash_Withdrawal_Screen.Visible == true) {
        Cash_Withdrawal_Field.Text += "0";
      }
    }

    private void button_Double_Zero(object sender, EventArgs e) {
      playBeep();

      if (PIN_Code_Screen.Visible == true) {
        PIN_Code.Text += "00";
      } else if (Cash_Deposit_Screen.Visible == true) {
        Cash_Deposit_Field.Text += "00";
      } else if (Cash_Withdrawal_Screen.Visible == true) {
        Cash_Withdrawal_Field.Text += "00";
      }
    }

    private void button_Point(object sender, EventArgs e) {
      playBeep();

      if (PIN_Code_Screen.Visible == true) {
        PIN_Code.Text += ".";
      } else if (Cash_Deposit_Screen.Visible == true) {
        Cash_Deposit_Field.Text += ".";
      } else if (Cash_Withdrawal_Screen.Visible == true) {
        Cash_Withdrawal_Field.Text += ".";
      }
    }

    // Кнопки Отмены, Сброса, Ввода и Пустая

    private void button_Cancel(object sender, EventArgs e) {
      playBeep();
    }

    private void button_Clear(object sender, EventArgs e) {
      playBeep();

      if (PIN_Code_Screen.Visible == true) {
        PIN_Code.Text += "";
      } else if (Cash_Deposit_Screen.Visible == true) {
        Cash_Deposit_Field.Text += "";
      } else if (Cash_Withdrawal_Screen.Visible == true) {
        Cash_Withdrawal_Field.Text += "";
      }
    }
    private void button_Enter(object sender, MouseEventArgs e) {
      playBeep();

      if (PIN_Code_Screen.Visible == true) {
        int enteredPinCode;
        if (int.TryParse(PIN_Code.Text, out enteredPinCode)) {
          if (enteredPinCode == BankCard.PINCode) {
            MessageBox.Show("Выполнен успешный код!");
            PIN_Code_Screen.Visible = false;

            Loading_Screen.Visible = true;

            Thread.Sleep(2000);

            Loading_Screen.Visible = false;
            Main_Screen.Visible = true;

            PIN_Code.Text = "";
          } else {
            MessageBox.Show("Неправильный пин-код!\nПовторите попытку.");
            NumberOfAttempts++;

            if (NumberOfAttempts == 3) {
              MessageBox.Show("Вы трижды вели неправильный пароль!");
              PIN_Code_Screen.Visible = false;
              Locked_ATM_Screen.Visible = true;
            }
          }
        }
      } 
    }


    private void button_Empty(object sender, EventArgs e) {
      playBeep();

      MessageBox.Show("Для чего я создан?");
    }

    // Кнопки Вставить карту, Забрать карту, Вставить карту 

    private void button_Insert_Card(object sender, EventArgs e) {
      Home_Screen.Visible = false;
      Loading_Screen.Visible = true;
      button_Card_Insert.Visible = false;
      Thread.Sleep(2000);
      Loading_Screen.Visible = false;
      PIN_Code_Screen.Visible = true;
    }

    private void button_Pick_Up_Card(object sender, EventArgs e) {
      Thread.Sleep(1000);
      Button_Pick_Up_Card.Visible = false;
      button_Card_Insert.Visible = true;
    }

    private void button_Insert_Banknotes(object sender, EventArgs e) {

    }
    /* Экраны с элементами
     
    Главный экран банкомата */
    private void main_Screen_Paint(object sender, PaintEventArgs e) { }

    private void button_Cash_Deposit(object sender, EventArgs e) {
      Main_Screen.Visible = false;
      Loading_Screen.Visible = true;
      Thread.Sleep(3000);
      Loading_Screen.Visible = false;
      Cash_Deposit_Screen.Visible = true;
    }

    private void button_Withdraw_Cash(object sender, EventArgs e) {
      Main_Screen.Visible = false;
      Loading_Screen.Visible = true;
      Thread.Sleep(3000);
      Loading_Screen.Visible = false;
      Cash_Withdrawal_Screen.Visible = true;
    }

    private void button_My_Account(object sender, EventArgs e) {
      Main_Screen.Visible = false;
      Loading_Screen.Visible = true;
      Thread.Sleep(3000);
      Loading_Screen.Visible = false;
      Personal_Account_Screen.Visible = true;
    }

    private void button_Exit_1(object sender, EventArgs e) {
      Thread.Sleep(200);
      Main_Screen.Visible = false;
      Home_Screen.Visible = true;
      button_Card_Insert.Visible = false;
      Button_Pick_Up_Card.Visible = true;

    }

    private void Welcome_And_Name_Field_Click(object sender, EventArgs e) {
      HideCaret(Welcome_And_Name_Field.Handle);
    }
    private void Time_And_Date_Field_Click(object sender, EventArgs e) {
      HideCaret(Time_And_Date_Field.Handle);
    }

    private void Timer_Tick(object sender, EventArgs e) {
      DateTime currentTime = DateTime.Now;
      string formattedDateTime = currentTime.ToString("dd/MM/yyyy HH:mm");
      Time_And_Date_Field.Text = formattedDateTime;
      Time_And_Date_Field.TextAlign = HorizontalAlignment.Center;
    }

    // Экран ПИН-кода
    private void PIN_Code_Screen_Paint(object sender, PaintEventArgs e) { }

    private void PIN_Code_KeyPress(object sender, KeyPressEventArgs e) {
      if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar)) {
        e.Handled = true;
      }

      HideCaret(PIN_Code.Handle);
    }

    private void PIN_Code_TextChanged(object sender, EventArgs e) {
      if (PIN_Code.Text.Length > 4) {
        PIN_Code.Text = PIN_Code.Text.Substring(0, 4);
      }
    }

    // Экран личного кабинета
    private void personal_Account_Screen_Paint(object sender, PaintEventArgs e) { }

    private void card_Balance_TextChanged(object sender, EventArgs e) { }

    private void button_Home_5(object sender, EventArgs e) {
      Personal_Account_Screen.Visible = false;
      Loading_Screen.Visible = true;
      Thread.Sleep(3000);
      Loading_Screen.Visible = false;
      Main_Screen.Visible = true;
    }

    // Главный экран внесения наличных

    private void cash_Deposit_Screen_Paint(object sender, PaintEventArgs e) {

    }
    private void Cash_Deposit_Field_KeyPress(object sender, KeyPressEventArgs e) {
      if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar)) {
        e.Handled = true;
      }
    }

    private void Cash_Deposit_Field_KeyDown(object sender, KeyEventArgs e) {
      
    }

    private void Сash_Deposit_Field_TextChanged(object sender, EventArgs e) { }

    private void button_Deposit(object sender, EventArgs e) {
      if (int.TryParse(Cash_Deposit_Field.Text, out int depositAmount)) {
        if (depositAmount > 0) {
          BankCard.WalletCash += depositAmount;
          BankCard.BalanceCard += depositAmount;

          BankCard.SaveDataToFile("userdata.txt");

          MessageBox.Show($"Средства внесены успешно. Новый баланс: {BankCard.BalanceCard}");

          Cash_Deposit_Field.Text = "";
        } else {
          MessageBox.Show("Некорректная сумма для внесения. Повторите попытку!");
        }
      } else {
        MessageBox.Show("Некорректное значение суммы для внесения. Повторите попытку!");
      }

      Cash_Deposit_Screen.Visible = false;
      Cash_Waiting_Screen.Visible = true;
      Thread.Sleep(3000);
      Cash_Waiting_Screen.Visible = false;
      Successful_Cash_Deposit_Screen.Visible = true;
    }

    private void button_Home_4(object sender, EventArgs e) {
      Thread.Sleep(500);
      Cash_Deposit_Screen.Visible = false;
      Loading_Screen.Visible = true;
      Thread.Sleep(3000);
      Loading_Screen.Visible = false;
      Main_Screen.Visible = true;
    }

    // Экран успешного внесения наличных 

    private void successful_Cash_Deposit_Screen_Paint(object sender, PaintEventArgs e) {

    }

    private void button_Exit_2(object sender, EventArgs e) {
      Thread.Sleep(500);
      Successful_Cash_Deposit_Screen.Visible = false;
      Loading_Screen.Visible = true;
      Thread.Sleep(3000);
      Loading_Screen.Visible = false;
      Home_Screen.Visible = true;
      button_Card_Insert.Visible = false;
      Thread.Sleep(3000);
      Button_Pick_Up_Card.Visible = true;
    }

    private void button_Home_1(object sender, EventArgs e) {
      Thread.Sleep(500);
      Successful_Cash_Deposit_Screen.Visible = false;
      Loading_Screen.Visible = true;
      Thread.Sleep(3000);
      Loading_Screen.Visible = false;
      Main_Screen.Visible = true;
    }

    // Экран снятия наличных 

    private void cash_Withdrawal_Screen_Paint(object sender, PaintEventArgs e) { }


    private void cash_Withdrawal_Field_TextChanged(object sender, EventArgs e) {

    }

    private void Cash_Withdrawal_Field_KeyPress(object sender, KeyPressEventArgs e) {
      if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar)) {
        e.Handled = true;
      }
    }

    private void button_Withdraw(object sender, EventArgs e) {
      if (int.TryParse(Cash_Withdrawal_Field.Text, out int withdrawAmount)) {
        if (withdrawAmount <= BankCard.BalanceCard) {
          BankCard.BalanceCard -= withdrawAmount;
          BankCard.WalletCash -= withdrawAmount;

          сard_Balance.Text = BankCard.BalanceCard.ToString() + " ₽";

          BankCard.SaveDataToFile("userdata.txt");

          Cash_Withdrawal_Screen.Visible = false;
          Cash_Withdrawal_Waiting_Screen.Visible = true;
          Thread.Sleep(3000);

          Cash_Withdrawal_Waiting_Screen.Visible = false;
          Successful_Cash_Withdrawal_Deposit_Screen.Visible = true;

          сard_Balance.Text = "";
          MessageBox.Show($"Сумма {withdrawAmount} рублей успешно снята.");
        } else {
          MessageBox.Show("Недостаточно средств на балансе карты!\nПовторите попытку");
        }
      } else {
        MessageBox.Show("Введите корректную сумму для снятия наличных!");
      }
    }

    private void button_Home_3(object sender, EventArgs e) {
      Cash_Withdrawal_Screen.Visible = false;
      Loading_Screen.Visible = true;
      Thread.Sleep(3000);
      Loading_Screen.Visible = false;
      Main_Screen.Visible = true;
    }

    // Экран успешного снятия наличных 

    private void successful_Cash_Withdrawal_Deposit_Screen_Paint(object sender, PaintEventArgs e) { }


    private void button_Exit_3(object sender, EventArgs e) {
      Thread.Sleep(500);
      Main_Screen.Visible = false;
      Home_Screen.Visible = true;
      button_Card_Insert.Visible = false;
      Button_Pick_Up_Card.Visible = true;
    }

    private void button_Home_2(object sender, EventArgs e) {
      Successful_Cash_Withdrawal_Deposit_Screen.Visible = false;
      Loading_Screen.Visible = true;
      Thread.Sleep (3000);
      Loading_Screen.Visible = false;
      Main_Screen.Visible = true;

    }

    /* Экраны без элементов
     
    Начальный экран */

    private void home_Screen_Paint(object sender, PaintEventArgs e) { }

    // Экран заблокированного банкомата
    private void locked_ATM_Screen_Paint(object sender, PaintEventArgs e) { }

    // Экран обычной загрузки
    private void loading_Screen_Paint(object sender, PaintEventArgs e) { }

    // Экран загрузки снятия наличных
    private void cash_Waiting_Screen_Paint(object sender, PaintEventArgs e) { }

    // Экран загрузки внесения наличных
    private void cash_Withdrawal_Waiting_Screen_Paint(object sender, PaintEventArgs e) { }
  }
}
