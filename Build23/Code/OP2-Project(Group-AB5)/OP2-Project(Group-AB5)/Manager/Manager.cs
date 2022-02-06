using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

/// <summary>
/// 2020-10-26
/// Group AB5 -
/// André Normann
/// Viktor Klang
/// Denise Peterson
/// David Ahlström
/// </summary>
namespace OP2_Project_Group_AB5_
{

    /// <summary>
    /// Manages the order datatype with a list and ways to manipulate it.
    /// </summary>


    public class Manager<T> : IManager<T>
    {
        protected List<T> ObservableList = new List<T>();
        public event UpdateDelegate ListEvent;
        
        
        /// <summary>
        /// Method to add orders into the generic lists
        /// </summary>
        /// <param name="order"></param>
        public void Add(T order)
        {
            ObservableList.Add(order);
            ListEvent?.Invoke();
        }

        /// <summary>
        /// returns observablelist
        /// </summary>
        /// <returns></returns>
        public List<T> GetList()
        {
            return ObservableList;
        }

        /// <summary>
        /// removes selected item for the list
        /// </summary>
        /// <param name="order"></param>
        public void Remove(T item)
        {
            ObservableList.Remove(item);
            ListEvent?.Invoke();
        }

        /// <summary>
        /// invokes the listevent
        /// </summary>
        public void InvokeEvent()
        {
            ListEvent?.Invoke();
        }



        /// <summary>
        /// changes the selected item
        /// </summary>
        /// <param name="tOld"></param>
        /// <param name="tNew"></param>
        public void Change(T tOld, T tNew)
        {
            ObservableList[ObservableList.FindIndex(ind => ind.Equals(tOld))] = tNew;
            ListEvent?.Invoke();
        }
    }
}
