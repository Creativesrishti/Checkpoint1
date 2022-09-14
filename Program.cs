int index = 0;
string[] products=new string[10];
string val="";

Console.WriteLine("Enter Products. Finish by typing Exit");

while (val != "exit")
{
   // Console.WriteLine("Add a product");
    val = Console.ReadLine();
    if (val == "exit")
    {
        break;

    }
    products[index] = val;
    index++;

}

Array.Resize(ref products, index);
Console.WriteLine("You entered following products");

for (index = 0; index < products.Length; index++)
{
    Console.WriteLine(products[index]);
}


