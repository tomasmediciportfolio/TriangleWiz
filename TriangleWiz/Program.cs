using System;
using System.Collections.Generic;

namespace TriangleWiz
{
    class Program
    {
        static void Main(string[] args)
        {
            TriangleWizard wiz = new TriangleWizard();

            List<List<int>> triangleList = new List<List<int>>();
            triangleList.Add(new List<int> { 215 });
            triangleList.Add(new List<int> { 192, 124 });
            triangleList.Add(new List<int> { 117, 269, 442 });
            triangleList.Add(new List<int> { 218, 836, 347, 235 });
            triangleList.Add(new List<int> { 320, 805, 522, 417, 345 });
            triangleList.Add(new List<int> { 229, 601, 728, 835, 133, 124 });
            triangleList.Add(new List<int> { 248, 202, 277, 433, 207, 263, 257 });
            triangleList.Add(new List<int> { 359, 464, 504, 528, 516, 716, 871, 182 });
            triangleList.Add(new List<int> { 461, 441, 426, 656, 863, 560, 380, 171, 923 });
            triangleList.Add(new List<int> { 381, 348, 573, 533, 448, 632, 387, 176, 975, 449 });
            triangleList.Add(new List<int> { 223, 711, 445, 645, 245, 543, 931, 532, 937, 541, 444 });
            triangleList.Add(new List<int> { 330, 131, 333, 928, 376, 733, 017, 778, 839, 168, 197, 197 });
            triangleList.Add(new List<int> { 131, 171, 522, 137, 217, 224, 291, 413, 528, 520, 227, 229, 928 });
            triangleList.Add(new List<int> { 223, 626, 034, 683, 839, 052, 627, 310, 713, 999, 629, 817, 410, 121, });
            // triangleList.Add(new List<int> { 924, 622, 911, 233, 325, 139, 721, 218, 253, 223, 107, 233, 230, 124, 233 });

            (int, List<int>) result = wiz.CalculatePath(triangleList);
            Console.WriteLine("Output: ");
            Console.WriteLine("Max sum: {0}: ", result.Item1);
            Console.WriteLine("Path: " + String.Join(", ", result.Item2));
        }
    }
}
