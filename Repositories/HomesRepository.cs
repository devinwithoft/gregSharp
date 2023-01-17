using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace gregSharp.Repositories;

public class HomesRepository
{
  private readonly IDbConnection _db;

  public HomesRepository(IDbConnection db)
  {
    _db = db;
  }

  internal List<Home> Get()
  {
    string sql = @"SELECT
  *
  FROM homes;
  ";
    List<Home> homes = _db.Query<Home>(sql).ToList();
    return homes;
  }

  internal Home Get(int id)
  {
    string sql = @"
  SELECT
  *
  FROM homes
  WHERE id = @id;
  ";
    Home home = _db.QueryFirstOrDefault<Home>(sql, new { id });
    return home;
  }

  internal bool Remove(int id)
  {
    string sql = @"
    DELETE
    FROM homes
    Where id = @id;
    ";
    int deleted = _db.Execute(sql, new { id });
    return deleted > 0;
  }

  internal bool Update(Home original)
  {
    string sql = @"
  UPDATE homes
  SET
  beds = @beds,
  baths = @baths,
  price= @price,
  imgUrl = @imgUrl,
  description = @description
WHERE id = @id;
  ";
    int rows = _db.Execute(sql, original);
    return rows > 0;
  }


  internal Home Create(Home homeData)
  {
    string SQL = @"
  INSERT INTO homes
  (beds, baths, price, imgUrl, description)
  VALUES
  (@beds, @baths, @price, @imgUrl, @description);
  
  SELECT LAST_INSERT_ID();
  ";
    int id = _db.ExecuteScalar<int>(SQL, homeData);
    homeData.Id = id;
    return homeData;
  }
}
