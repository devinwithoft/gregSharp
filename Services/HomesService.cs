using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace gregSharp.Services;

public class HomesService
{
  private readonly HomesRepository _repo;

  public HomesService(HomesRepository repo)
  {
    _repo = repo;
  }


  internal List<Home> Get()
  {
    List<Home> homes = _repo.Get();
    return homes;
  }

  internal Home Get(int id)
  {
    Home home = _repo.Get(id);
    if (home == null)
    {
      throw new Exception("no home at that ID");
    }
    return home;
  }

  internal String Remove(int id)
  {
    Home home = Get(id);
    bool deleted = _repo.Remove(id);
    if (deleted == false)
    {
      throw new Exception("No home was deleted");
    }
    return $"{home.beds} Bedrooms, {home.baths} bathrooms home deleted";
  }


  internal Home Update(Home homeUpdate, int id)
  {
    Home original = Get(id);
    original.baths = homeUpdate.baths ?? original.baths;
    original.beds = homeUpdate.beds ?? original.beds;
    original.price = homeUpdate.price ?? original.price;
    original.imgUrl = homeUpdate.imgUrl ?? original.imgUrl;
    original.description = homeUpdate.description ?? original.description;

    bool edited = _repo.Update(original);
    if (edited == false)
    {
      throw new Exception("Home was not editted");
    }
    return original;
  }

  internal Home Create(Home homeData)
  {
    Home home = _repo.Create(homeData);
    return home;
  }
}
