using System.Collections.Generic;

namespace Calc.Views.Home
{
    public class SampleData
    {
        public static List<CalcDescription> Companies = new List<CalcDescription> {
            new CalcDescription {
                ID = 1,
                Name = "Wskaźnik BMI",
                Description = "BMI (ang. body mass index) to wskaźnik masy ciała w stosunku do wzrostu. Za pomocą wskaźnika BMI dowiesz się czy Twoja aktualna masa ciała jest prawidłowa, czy wymaga modyfikacji. BMI porównuje wagę ze wzrostem i oblicza je, dzieląc wagę w kilogramach przez wzrost w metrach. Kalkulator BMI jest jednym z narzędzi, które pomagają specjalistom ds. zdrowia w ocenie ryzyka wystąpienia przewlekłej choroby. Innym ważnym narzędziem jest obwód talii. ",
            },
            new CalcDescription {
                ID = 2,
                Name = "Całkowita przemiana materii",
                Description = "Określa całodobowy wydatek energetyczny człowieka, na który składają się wydatki związane z prawidłowym funkcjonowaniem organizmu (czyli oddychanie, praca serca, itp.) oraz wydatki energetyczne związane z życiem codziennym, pracą zawodową, wysiłkiem fizycznym.",
            },
            new CalcDescription {
                ID = 3,
                Name = "Należna masa ciała - Wzór Broca",
                Description = "Broca założył, że idealna waga człowieka to wzrost w cm - 100. Wzór ten został na przestrzeni lat udoskonalony przez dietetyków. Wynik wyliczony wzorem Broca powinien zostać zmniejszony o 10% w przypadku młodych kobiet natomiast o 5% w przypadku młodych mężczyzn.",
            },
            new CalcDescription {
                ID = 4,
                Name = "Idealna masa ciała - Wzór Lorenza",
                Description = "Dzięki wzorowi Lorenza możemy obliczyć naszą idealną wagę dla podanego wzrostu. Od naszej wagi odejmujemy 100  Aby obliczyć idealną wagę wg. wzoru Lorenza możesz skorzystać z naszego kalkulatora. Wybierz płeć oraz podaj swój wzrost. Wzór Lorenza jest wykorzystywany dla osób, których wzrost wynosi powyżej 150cm.",
            }
        };
    }
    public class CalcDescription
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
    }
}