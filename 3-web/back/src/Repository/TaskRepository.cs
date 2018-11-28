using System.Collections;
using System;
using src.Model;

namespace src.Repository{

    public class TaskRepository{

        public IEnumerable GetAllTasks(){
            yield return new Task{Id=1,Content="hello"};
            yield return new Task{Id=2,Content="world", Date =DateTime.Now};
        }     
    }

}