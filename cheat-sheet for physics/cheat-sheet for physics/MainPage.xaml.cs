using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace cheat_sheet_for_physics
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class MainPage : ContentPage
    {
        /*
         case "":
             Answer.Text = AnswerClass.Answer(); AnswerNumber.Text = "Вопрос: ";
             break;
         */
        public MainPage()
        {
            InitializeComponent();
        }

        private void QuestionNumber_TextChanged(object sender, TextChangedEventArgs e)
        {
            switch (QuestionNumber.Text)
            {
                case "1": 
                    Answer.Text = AnswerClass.Answer1(); AnswerNumber.Text = "Вопрос: 1. Основные положения МКТ.";
                    break;
                case "2": 
                    Answer.Text = AnswerClass.Answer2(); AnswerNumber.Text = "Вопрос: 2. Что изучает МКТ?";
                    break;
                case "3":
                    Answer.Text = AnswerClass.Answer3(); AnswerNumber.Text = "Вопрос: З. Основные положения МКТ.";
                    break;
                case "4":
                    Answer.Text = AnswerClass.Answer4(); AnswerNumber.Text = "Вопрос: 4. Диффузия. Скорость диффузии.";
                    break;
                case "5":
                    Answer.Text = AnswerClass.Answer5(); AnswerNumber.Text = "Вопрос: 5. Что диффузия доказывает?";
                    break;
                case "6":
                    Answer.Text = AnswerClass.Answer6(); AnswerNumber.Text = "Вопрос: 6. Броуновское движение Отчего зависит скорость броуновскоо движения?";
                    break;
                case "7":
                    Answer.Text = AnswerClass.Answer7(); AnswerNumber.Text = "Вопрос: 7. Привести доказательства а) молекулярного строения вещества; б)взаимодействия молекул.";
                    break;
                case "8":
                    Answer.Text = AnswerClass.Answer8(); AnswerNumber.Text = "Вопрос: 8. Количество вещества, единица измерения.";
                    break;
                case "9":
                    Answer.Text = AnswerClass.Answer9(); AnswerNumber.Text = "Вопрос: 9. Число Авогадро. Что оно показывает?";
                    break;
                case "10":
                    Answer.Text = AnswerClass.Answer10(); AnswerNumber.Text = "Вопрос: 10. Молярная масса, единица измерения.";
                    break;
                case "11":
                    Answer.Text = AnswerClass.Answer11(); AnswerNumber.Text = "Вопрос: 11. Определить молярную массу а) Nа Сl 6) СО2»: в) СО";
                    break;
            }
        }
    }

    public class AnswerClass : MainPage 
    {
        /*
        public static string Answer()
        {
            return "";
        }
         */
        public static string Answer1()
        {
            
            return "1.Все состоит из молекул\n2.Молекулы движутся беспорядочно\nМолекулы взаимодействуют между собой";
        }
        public static string Answer2()
        {
            return "МКТ изучает молекулярное строение тел и его изменение при изменении его температуры";
        }
        public static string Answer3()
        {
            return Answer1();
        }
        public static string Answer4()
        {
            return "Диффузия - Это процесс перехода молекулодного вещества в другое(взаимный)";
        }
        public static string Answer5()
        {
            return "Диффузия доказывает 2 положение МКТ";
        }
        public static string Answer6()
        {
            return "Броуновское движение - это хаотичное, беспорядочное движение частиц в жидкостях и газах";
        }
        public static string Answer7()
        {
            return "a)Испарение, увелечени/уменьшение объема\nb)Катализаторы, ядерный синтез";
        }
        public static string Answer8()
        {
            return "Кол-во вещества - это кол-во элементов вещества, равное кол-ву в 12г углерода. Измеряется в молях";
        }
        public static string Answer9()
        {
            return "Число Авогардо показываетпоказывает кол-во элементов в веществе в 1 моле";
        }
        public static string Answer10()
        {
            return "Молярная масса - это количество киллограмм на 1 моль вещества. Измеряется в кг/моль";
        }
        public static string Answer11()
        {
            return "a) 58 * 10⁻³\nб) 44 * 10⁻³\nв)28";
        }
    }
}
