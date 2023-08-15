
while (true)
{
    Console.WriteLine("****************************************************");
    Console.Write("Enter your NationalCode: ");
    string key = Console.ReadLine();
    if (key == null || key == "" || key.Contains(" "))
    {
        Console.WriteLine(" code meli vared shode eshtebah ast");
        Console.WriteLine("mojadad vared konid");
    }
    else
    {
        if (key.Length != 10)
        {
            Console.WriteLine("tedad adad argham code meli eshtebah ast");
        }
        else
        {
            bool istrue = true;
            for (int i = 0; i < 10; i++)
            {
                if (!char.IsDigit(key[i]))
                {
                    istrue = false;
                    Console.WriteLine("code meli vared shode eshtebah ast ");
                    break;
                }
            }
            if (istrue)
            {
                int sum = 0;
                for (int i = 0; i < 9; i++)
                {
                    sum += (int)char.GetNumericValue(key[i]) * (10 - i);
                }
                int r = sum % 11;
                if (r < 2)
                {
                    if (char.GetNumericValue(key[9]) == r)
                    {
                        Console.WriteLine("code meli vared shode doroste ast");

                    }
                    else
                    {
                        Console.WriteLine("code meli vared shode eshtebah ast ");
                    }
                }
                else
                {
                    int x = 11 - r;
                    if (char.GetNumericValue(key[9]) == x)
                    {
                        Console.WriteLine("code meli vared shode doroste ast");

                    }
                    else
                    {
                        Console.WriteLine("code meli vared shode eshtebah ast ");
                    }
                }
            }

        }
    }
}