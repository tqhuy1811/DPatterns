using System;

/*
 Purpose of this pattern is to decoupled abstraction and implementation through the usage of composition
 which begs the question what's the purpose of inheritance in the first place ?

 Composition is generally good but this introduce additional complexity 
*/
namespace DesignPattern
{
    public interface IRepository
    {
        void Save();
    }

    public interface IPersistenceImplementor
    {
        void Save();
    }

    public class FilePersistence : IPersistenceImplementor
    {
        public void Save()
        {
            Console.WriteLine("Save file");
        }
    }

    public class Repository : IRepository
    {
        private readonly IPersistenceImplementor persistenceImplementor;

        public Repository(IPersistenceImplementor persistenceImplementor)
        {
            this.persistenceImplementor = persistenceImplementor;
        }
        public void Save()
        {
           this.persistenceImplementor.Save();
        }
    }
}
