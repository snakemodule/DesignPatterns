using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnityEngine.Assertions;

namespace FutureGames.JRPG_Rocket
{
    /// <summary>
    /// old stuff, statemachine previously used a tuple as input for
    /// which states to use before reflection was implemented.
    /// </summary>
    static class TupleHelper
    {
        public static int GetSize(Type tuple)
        {
            var genericArguments = tuple.GetGenericArguments();
            if (genericArguments.Length > 7)
            {
                return 7 + GetSize(genericArguments[7]);
            }
            else
            {
                return genericArguments.Length;
            }
        }
        
        //gets new instances from the types of a tuple
        public static void GetInstances<T>(Type tuple, List<T> list)
        {
            var genericArguments = tuple.GetGenericArguments();

            for (int i = 0; i < genericArguments.Length-1; i++)            
            {                
                Assert.IsTrue(genericArguments[i].BaseType == typeof(T));
                list.Add((T)Activator.CreateInstance(genericArguments[i]));
            }
            if (genericArguments.Length > 7)
            {
                GetInstances(genericArguments[7], list);
            }
        }

    }
}
