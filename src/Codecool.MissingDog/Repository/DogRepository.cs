using System;
using Codecool.MissingDog.Model;
using System.Collections.Generic;
using System.Linq;

namespace Codecool.MissingDog.Repository
{
    /// <summary>
    ///     Provides all needed methods on dogs data.
    /// </summary>
    public class DogRepository
    {
        private DataSource _data { get; set; }

        /// <summary>
        ///     Initiates a new instance of DogRepository based on given DataSource.
        /// </summary>
        /// <param name="data"></param>
        public DogRepository(DataSource data)
        {
            _data = data;

            

        }

        /// <summary>
        ///     Gets all dogs from data.
        /// </summary>
        /// <returns> IEnumerable of all Dogs instances and nulls. </returns>
        public IEnumerable<Dog> GetAllDogs()
        {
            //throw new NotImplementedException();
            /*
            Implement all methods in the DogRepository class.
            The GetAllDogs() method returns an IEnumerable<Dog> of all Dog instances 
            (including null references) from provided data from DataSource class.
            */
            return _data.Dogs;
        }

        /// <summary>
        ///     Gets a specific dog with given Id.
        /// </summary>
        /// <param name="id">dogId</param>
        /// <returns> Dog instance or null. </returns>
        public Dog GetDogById(int id)
        {
            //throw new NotImplementedException();
            /*
              The GetDogById() method returns a 
             * specific Dog instance with given Id, if exists. If doesn't, returns null*/
            //Dog found = null;
            /*
            foreach (Dog dog in _data.Dogs)
            {
                //if ((dog != null) && (dog.Id == id))
                if(dog ?.Id == id)// równoznaczne z powy¿sz¹ linijk¹ 
                {
                    found = dog;
                }
            }
            */
            //return found;
            return _data.Dogs.FirstOrDefault<Dog>(dog => dog?.Id == id);

        }

/// <summary>
///     Counts all dogs that are assigned to an owner of a dog with given Id.
/// </summary>
/// <param name="dogId">dogId</param>
/// <returns> Integer, representing Dogs count. </returns>
public int GetCountOfDogsForTheOwnerOfDogWithId(int dogId)
{
            //throw new NotImplementedException();
            /*
            The GetCountOfDogsForTheOwnerOfDogWithId() method returns
            the count of Dog instances which are assigned to an Owner of a Dog with a given Id.*/

            //return _data.Owners[0].Dogs[0].Id
            Dog dog = _data.Dogs.FirstOrDefault<Dog>(dog => dog?.Id == dogId);
            return dog?.Owner?.Dogs.Count(d => d!=null) ?? 0;

}

/// <summary>
///     Gets phone number of the dog owner with the given Id.
/// </summary>
/// <param name="dogId">dogId</param>
/// <returns> String, representing phone number. </returns>
public string GetOwnerPhoneNoByDogId(int dogId)
{
            //throw new NotImplementedException();
            /*
             * The GetOwnerPhoneNoByDogId() method returns PhoneNumber
             * of the Dog instance Owner with a given Id, if exists. 
             * If doesn't, returns a string "Missing data".
             */

            Dog dog = _data.Dogs.Where<Dog>(D => D?.Id == dogId).FirstOrDefault();

            return dog?.Owner?.PhoneNumber ?? "Missing data";





}

/// <summary>
///     Gets all dogs with a given sociability.
/// </summary>
/// <param name="isSociable">isSociable</param>
/// <returns> IEnumerable of Dogs instances. </returns>
public IEnumerable<Dog> GetDogsBySociability(bool isSociable)
{
            /*throw new NotImplementedException();
            The GetDogsBySociability() method returns an IEnumerable<Dog> 
            of all Dog instances with a given Sociability.
            */

            return _data?.Dogs?.Where(S => S?.IsSociable == isSociable);


}
}
}
