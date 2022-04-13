    {
        Console.WriteLine("Enter the numbers YOu want and put a comma after each digit : ");
        var name = Console.ReadLine();
        var numarray = name.Split(',');
        Array.Sort(numarray);
        int firstDigit = Convert.ToInt32(numarray[0]);
         
        bool cons = true;
        
        for (var i = 0;i<numarray.Length;i++ )
        
        {
            if (Convert.ToInt32(numarray[i])-i != firstDigit)
            
            {
                cons = false;                   
                break;
            }
            
        }
        if (cons)

        {
            Console.WriteLine("True!");
        }

        else
        {       
            Console.WriteLine("False!");   
        }

    }

