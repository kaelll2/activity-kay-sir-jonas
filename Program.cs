using System;
using OOP;

class MainProgram
{
    public static void Main()
    {
        OOP.ManageProduct.InsertNewProduct newProduct = new OOP.ManageProduct.InsertNewProduct();
        string productname;
        string productdescription;
        int productprice;
        int limit = 0;
        int setter;


        Console.WriteLine(@"
                                           
 =======================================================================================================================



                       / __ \_________  ____/ /_  _______/ /_   /  _/___  ________  _____/ /_(_)___  ____ 
                      / /_/ / ___/ __ \/ __  / / / / ___/ __/   / // __ \/ ___/ _ \/ ___/ __/ / __ \/ __ \
                     / ____/ /  / /_/ / /_/ / /_/ / /__/ /_   _/ // / / (__  )  __/ /  / /_/ / /_/ / / / /
                    /_/   /_/   \____/\__,_/\__,_/\___/\__/  /___/_/ /_/____/\___/_/   \__/_/\____/_/ /_/ 



 =======================================================================================================================");

        Console.Write(@"
 

                                                 | Enter insertion limit: |

                                                         - ");

        while (!int.TryParse(Console.ReadLine(), out setter) || setter < 0)
        {

            Console.Write(@"
                
                                               | Please input a valid range: |

                                                         - ");
        }
        Console.Clear();


        do
        {


            do
            {
                product.lineBreaker.lineBreak();
                Console.Clear();
                Console.Write(@"
______  ___________  _______________ _   ________  __  ___ _   ______  
| __| \||_ _| __| . \ | . | . |   |  \|| \| __|_ _\ | \||  \|\/\| __|_] 
|  ]|  \| |||  ]|  <_ | __|  <| . | . ||_|| \__ ||  |  \| . |   |  ],-. 
|___|/\_/ |/|___|/\_/ |/  |/\_|___|___|___|___/ |/  |/\_|/\_|/v\|___'-'

 - ");
                productname = Console.ReadLine();

            } while (string.IsNullOrEmpty(productname));

            product.lineBreaker.lineBreak();
            Console.Write(@"
______  ____________  _______________ _   ________  ______________________   
| __| \||_ _| __| . \ | . | . |   |  \|| \| __|_ _\ | . | . |___| __| __|_]  
|  ]|  \| |||  ]|  <_ | __|  <| . | . ||_|| \__ ||  | __|  <| / | \_|  ],-.  
|___|/\_/ |/|___|/\_/ |/  |/\_|___|___|___|___/ |/  |/  |/\_|/  |___|___'-'  

 - ");

            while (!int.TryParse(Console.ReadLine(), out productprice) || productprice < 0)
            {
                product.lineBreaker.lineBreak();
                Console.Write(@"
                                        | Invalid input. Please enter a valid price: ");
            }


            do
            {
                product.lineBreaker.lineBreak();
                Console.Write(@"
______  ____________  _______________ _   ________  ___ _______ ______________________________  __  
| __| \||_ _| __| . \ | . | . |   |  \|| \| __|_ _\ |  \| __| _\| __| . |___| . |_ _|___|   | \||_] 
|  ]|  \| |||  ]|  <_ | __|  <| . | . ||_|| \__ ||  | . |  ][__ | \_|  <| / | __/ ||| / | . |  \,-. 
|___|/\_/ |/|___|/\_/ |/  |/\_|___|___|___|___/ |/  |___|___|___|___|/\_|/  |/    |/|/  |___|/\_'-' 

 - ");
                productdescription = Console.ReadLine();
            } while (string.IsNullOrEmpty(productdescription));

            Console.Clear();


            newProduct.InsertData(productname, productprice, productdescription);


            limit++;


        } while (limit < setter);



        Console.ReadKey();
    }
}
