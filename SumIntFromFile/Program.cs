
string path = @"C:\file-data-numbers.txt"; // файл уже создан, мы сохраняем путь к файлу

try
{
    // читает в консоли файл
    using (StreamReader streamReaderForRead = File.OpenText(path))
    {
        if (streamReaderForRead != null)
        {
            string streamTemps = "";
            while ((streamTemps = streamReaderForRead.ReadLine()) != null)
            {
                char[] stringArray = streamTemps.ToCharArray();

                int stringToInt = Convert.ToInt32(streamTemps);

                // этот кусок я взяла отсюда https://programm.top/c-sharp/problems/8/, если честно я смотрела как на документацию 🤷‍♀️
                // я вбила в поиск сумма числа c# и это первая ссылка...я смотрю, чтоб понять, что тут
                // как эту сумму взять...потому что у меня часа два были суммы, суммы, а сумма суммированная че то суммировалась суммарно
                var sumTotalFromArray = 0;
                while (stringToInt > 0) //при дебаге я вижу, что он исключил 0, и к примеру выдает 00127 => 127
                {
                    sumTotalFromArray += stringToInt % 10; //суммирует с конца, при каждом входе, добавляет предыдущее число
                    stringToInt /= 10; //зачем он делит на 10

                    //я понимаю, что вы сказали самой решать, тут я сама решила то, что знаю, а остальное учусь)))
                }
                Console.WriteLine(sumTotalFromArray);
            }
        }
    }
}
catch (Exception ex)
{
    Console.WriteLine(ex.ToString());
}


