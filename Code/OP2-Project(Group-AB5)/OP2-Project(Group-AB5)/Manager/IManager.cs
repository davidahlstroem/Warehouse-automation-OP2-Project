using System;
using System.Collections.Generic;

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
    /// Interface for the manager class
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public delegate void UpdateDelegate();

    public interface IManager<T>
    {
        event UpdateDelegate ListEvent;
        void Add(T t);
        List<T> GetList();
        void Remove(T t);
        void InvokeEvent();
        void Change(T tOld, T tNew);
    }
}
