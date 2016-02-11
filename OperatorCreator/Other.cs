using System;
using System.Collections.Generic;
using System.Linq;

namespace OperatorCreator
{

    public class Other {}

    public enum FieldVisibilitys
    {
        Hidden = 0 ,

        Display = 1 ,

        Check = 2 ,

        DisplayAndCheck = Check|Display ,

        Checkout = 4 ,

        CheckoutAndCheck = Checkout|Check ,

        All = CheckoutAndCheck|Display ,


    }

    public class FieldVisibility
    {

        public int Id { get; set; }

        public string Name { get; set; }

        public FieldVisibility(int id , string name)
        {
            Name = name;
            Id = id;
        }

        public static List<FieldVisibility> GetValues()
        {
            return Enum.GetValues(typeof (FieldVisibilitys)).Cast<FieldVisibilitys>().Select(x => new FieldVisibility((int)x , x.ToString())).ToList();
        }
    }

}