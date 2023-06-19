using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimulationATM {
  public class BankCard {
    public static string OwnersName { get; set; }
    public static int PINCode { get; set; }
    public static int BalanceCard { get; set; }
    public static int WalletCash { get; set; }

    public BankCard() {
      LoadDataFromFile("userdata.txt");
    }
    
    private void LoadDataFromFile(string filePath) {
      try {
        string[] lines = File.ReadAllLines(filePath);
        foreach (string line in lines) {
          string[] parts = line.Split('=');
          if (parts.Length == 2) {
            string propertyName = parts[0].Trim();
            string propertyValue = parts[1].Trim();

            switch (propertyName) {
              case "OwnersName":
                OwnersName = propertyValue;
                break;
              case "PINCode":
                PINCode = int.Parse(propertyValue);
                break;
              case "BalanceCard":
                BalanceCard = int.Parse(propertyValue);
                break;
              case "WalletCash":
                WalletCash = int.Parse(propertyValue);
                break;
            }
          }
        }
      } catch (FileNotFoundException) {
        Console.WriteLine("Ошибка: Файл с данными карты не найден.");
      } catch (Exception ex) {
        Console.WriteLine("Ошибка при чтении данных карты: " + ex.Message);
      }
    }

    public static void SaveDataToFile(string filePath) {
      try {
        using (StreamWriter writer = new StreamWriter(filePath)) {
          writer.WriteLine($"OwnersName={BankCard.OwnersName}");
          writer.WriteLine($"PINCode={BankCard.PINCode}");
          writer.WriteLine($"BalanceCard={BankCard.BalanceCard}");
          writer.WriteLine($"WalletCash={BankCard.WalletCash}");
        }
      } catch (Exception ex) {
        Console.WriteLine("Ошибка при сохранении данных в файл: " + ex.Message);
      }
    }
  }
}
