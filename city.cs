using System;
using System.Collections.Generic;

namespace planner {
       public class city {

           private string _name {get; set;}

           private string _mayor {get; set;}

           private DateTime _established {get; set;}

           private  List<Building> _allBuildings = new List<Building>();

           public List<Building> allBuildings {
               get{
                   return _allBuildings;
               }
               set{
                   allBuildings = _allBuildings;
               }
           }

            public void ExpandCity(Building building){
                _allBuildings.Add(building);
            }

               public city (string name) {
                   _established = DateTime.Now;
                   _name = name;
               }

               public void mayor(string name) {
                   _mayor = name;
               }
           }
       }
