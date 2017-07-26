using CsvHelper;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace PersonSorter
{
    public class PersonHelper
    {
        public List<Person> ReadCSV()
        {
            using (var csv = new CsvReader(File.OpenText("data.csv")))
            {
                var records = csv.GetRecords<Person>().ToList();
                return records;
            }
        }

        public List<KeyValuePair<string, int>> Q1()
        {
            var records = ReadCSV();
            var firstNames = records.Select(person => person.FirstName);

            var lastNames = records.Select(person => person.LastName);

            var result = firstNames.Concat(lastNames).GroupBy(item => item)
                        .Select(grouping => new KeyValuePair<string, int>(grouping.Key, grouping.Count()))
                        .OrderByDescending(item => item.Value)
                        .ThenBy(item => item.Key);

            return result.ToList();
        }

        public List<string> Q2()
        {
            var records = ReadCSV();
            var result = records.OrderBy(person => String.Join(" ", person.Address.Split(' ').Skip(1)))
                         .Select(person => person.Address);
            return result.ToList();
        }
    }

    public class Person
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Address { get; set; }
        public string PhoneNumber { get; set; }
    }
}