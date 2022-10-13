using System;

namespace EmployeePayrollManagement{
    public partial class List<Type>
    {
        public void Insert(int index,Type data)
        {   
            Type[] array2=new Type[_capacity+1];
            for (int i = 0; i <_count+1; i++)
            {
                if(i<index)
                {
                    array2[i]=Array[i];
                }
                else if(i==index)
                {
                    array2[i]=data;
                }
                else
                {
                    array2[i]=Array[i+1];
                }
            }
            Array=array2;
            _count++;
            
           
        }
        public void RemoveAt(int index)
        {
            for (int i = 0; i < _count; i++)
            {
                if(i>=index)
                {
                    Array[i]=Array[i+1];
                    
                }
                
            }
            _count--;
        }

       public void Remove(Type value)
       {
        for (int i = 0; i <_count; i++)
        {
            
            
                if(value.Equals(Array[i])){
                    for (int j = i; i <_count; i++)
                    {
                        
                    
                    Array[i]=Array[i+1];
                }
            }
        
        _count--;
       }
    }
}
}