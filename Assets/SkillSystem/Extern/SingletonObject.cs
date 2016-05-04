using System;
using System.Collections.Generic;
/// <summary>
/// ����ģʽ����������
/// </summary>
/// <typeparam name="T"></typeparam>
public class SingletonObject<T>
{
    private static T m_Singleton;

    public static T Instance
    {
        get
        {
            if (m_Singleton == null)
            {
                m_Singleton = (T)Activator.CreateInstance(typeof(T));
            }
            return m_Singleton;
        }
    }

}