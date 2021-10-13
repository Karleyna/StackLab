using System;

namespace StackLib
{
    public class MyStack<T>
    {
        public int count = 0;
        private int index_top = 0;
        private T[] array;

        private void Delete() //функция удаления всего массива
        {
            array = null;
        }
        public MyStack()
        {
            count = 3;
            array = new T[count];
        }
        public bool is_free()//проверка  хватает ли места в массиве
        {
            if (index_top < count) //индекс верхнего элемента сравниваем с размером
                return true;
            else return false;
        }
        public void Push(T new_elem)//вставка элемента в стек
        {
            if (!is_free())
            {
                Array.Resize(ref array, array.Length * 2);
                count *= 2;
            }
            array[index_top] = new_elem;
            index_top++;
        }
        public T Pop()//удаление элемента 

        {
            if (index_top < 1)
                throw new Exception("Error!");
            T top = array[index_top - 1];
            index_top--;
            return top;           
        }
       
        public int size()//вывод текущего размера стека
        {
            return index_top;
        }

        public void Push_stack(MyStack<T> new_stack)//вставка стека в стек
        {
            int index = new_stack.index_top - 1;
            Array.Resize(ref array, array.Length * 2);
            count *= 2;
            while (index >= 0)
            {
                if (!is_free())
                {
                    Array.Resize(ref array, array.Length * 2);
                    count *= 2;
                }

                array[index_top] = new_stack.array[index];
                index_top++;
                index--;
            }
            
        }
        public MyStack<T> Pop_stack(int countDeleted)//удаление стека в стеке
        {
            T[] temp = new T[countDeleted];
            MyStack<T> new_stack = new MyStack<T>();
            for (int i = 0; i < countDeleted; i++)
            {
                temp[i] = this.Pop();
                new_stack.Push(temp[i]);
            }
            return new_stack;
        }

        public void Show() //вывод стека
        {
            for (int i = 0; i < index_top; i++)
            {
                Console.Write($"{array[i]} "); 
            }

            Console.WriteLine();
        }

    }
}
