using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collections
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbersAsArray = { 1, 2, 3, 4, 5 };
            Array.Resize(ref numbersAsArray, numbersAsArray.Length+1);
            numbersAsArray[6] = 6;
            ArrayList arrayList = new ArrayList { 1, 2, 3, 4, 5 };
            arrayList.Add(6);
            arrayList.Remove(5);

            List<int> numbersAsList = new List<int> { 1, 2, 3, 4, 5, 6 };
            numbersAsList.Add(7);

            Dictionary<DayOfWeek, ICollection<string>> menu = new Dictionary<DayOfWeek, ICollection<string>>();
            menu.Add(DayOfWeek.Monday, new List<string>
            {
                "Завтрак - молочная каша",
                "Обед - гречка с мясом",
                "Ужин - хлебушек"
            });
            menu[DayOfWeek.Monday].Add("");

        }
    }
}
