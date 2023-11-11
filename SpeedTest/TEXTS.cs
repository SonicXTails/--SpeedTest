using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpeedTest
{
    internal class TEXTS
    {
        string RUSTEXT1 = "Семья Галлахеров - это дисфункциональная и непредсказуемая семейка, состоящая из" +
                        "\nшести детей и их отца Фрэнка. Мать, Моника, покинула их, и Фрэнк, страдающий алк" +
                        "\nоголизмом и лентяйством, неспособен заботиться о своих детях. Поэтому старший сы" +
                        "\nн, 20-летний Лип, истинный лидер семьи, принимает на себя ответственность за сво" +
                        "\nих младших братьев и сестер.";

        string RUSTEXT2 = "Уолтер берёт псевдоним Хайзенберг и разрабатывает свой уникальный продукт метамф" +
                        "\nетамина высокого качества. Сериал демонстрирует, как Уолтер, казалось бы, обычны" +
                        "\nй и добропорядочный человек, превращается в хладнокровного наркобарона. Его прев" +
                        "\nос ходные химические знания позволяют ему производить лучший наркотик на рынке, " +
                        "\nчто привлекает внимание криминалов.";

        string RUSTEXT3 = "История начинается с того, что Уилл Байерс и его друзья Майк, Дасти и Лукас игра" +
                        "\nют в настольную ролевую игру Дунджоны и драконы. Возвращаясь домой, Уилл исчезае" +
                        "\nт во время шторма. Его друзья начинают собственное расследование и обнаруживают " +
                        "\nстранного девочку, которую они называют Одиннадцать. Оказывается, что Одиннадцат" +
                        "\nь имеет сверхъестественные способности и была испытательным объектом лаборатории" +
                        "\n Лаборатории национальных лабораторий Хокинса (ЛНЛХ), где они проводил и опыты п" +
                        "\nо контролю различными психическими способностями.";

        string ENGTEXT1 = "The Gallagher family is a dysfunctional and unpredictable family consisting of s" +
                        "\nix children and their father Frank. Their mother, Monica, has left them, and Fra" +
                        "\nnk, suffering from alcoholism and laziness, is unable to take care of his childr" +
                        "\nen. Therefore, the eldest son, 20-year-old Lip, the true leader of the family, t" +
                        "\nakes responsibility for his\nyounger brothers and sisters.";

        string ENGTEXT2 = "Walter takes the pseudonym Heisenberg and develops his unique high-quality metha" +
                        "\nmphetamine product.The series demonstrates how Walter, seemingly an ordinary and" +
                        "\n respectable man, turns into a cold-blooded drug lord.His excellent chemical kno" +
                        "\nwledge allows him to produce the best drug on the market, which attracts the att" +
                        "\nention of criminals.";

        string ENGTEXT3 = "The story begins with Will Byers and his friends Mike, Dusty and Lucas playing t" +
                        "\nhe board role-playing game Dunjoons and Dragons. Returning home, Will disappears" +
                        "\n during a storm. His friends start their own investigation and discover a strang" +
                        "\ne girl they call Eleven. It turns out that Eleven has supernatural abilities and" +
                        "\n was a test facility of the Hawkins National Laboratories Laboratory (LNLH), whe" +
                        "\nre they conducted experiments on the control of various mental abilities.";

        public static string Random_RUTEXT()
        {
            var mc = new TEXTS();
            List<string> RUStexts = new List<string>() {mc.RUSTEXT1, mc.RUSTEXT2, mc.RUSTEXT3};


            var random = new Random();
            int index = random.Next(RUStexts.Count);

            return RUStexts[index];
        }

        public static string Random_ENGTEXT()
        {
            var mc = new TEXTS();
            List<string> ENGtexts = new List<string>() {mc.ENGTEXT1, mc.ENGTEXT2, mc.ENGTEXT3};


            var random = new Random();
            int index = random.Next(ENGtexts.Count);

            return ENGtexts[index];
        }
    }
}
