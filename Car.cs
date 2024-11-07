using System;
using SQLite;

namespace SQLite.MVVM.Models;

public class Car
{
    [PrimaryKey , AutoIncrement]
    public int ID { get; set; }
    [Column("Brand")]    
    public string Model { get; set; }
    [Column("Color")]  
    public string Color { get; set; }
}