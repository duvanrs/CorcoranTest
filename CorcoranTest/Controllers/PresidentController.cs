using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CorcoranTest.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CorcoranTest.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class PresidentController : ControllerBase
    {

        public static readonly List<PresidentModel> presidents = new List<PresidentModel>()
        {
            new PresidentModel(){President="George Washington",BirthDay="1732-2-22",BirthPlace="Westmoreland Co., Va.",DeathDay="1799-12-14",DeathPlace="Mount Vernon, Va."},
            new PresidentModel(){President="John Adams",BirthDay="1735-10-30",BirthPlace="Quincy, Mass.",DeathDay="1826-7-4",DeathPlace="Quincy, Mass."},
            new PresidentModel(){President="Thomas Jefferson",BirthDay="1743-4-13",BirthPlace="Albemarle Co., Va.",DeathDay="1826-7-4",DeathPlace="Albemarle Co., Va."},
            new PresidentModel(){President="James Madison",BirthDay="1751-3-16",BirthPlace="Port Conway, Va.",DeathDay="1836-6-28",DeathPlace="Orange Co., Va."},
            new PresidentModel(){President="James Monroe",BirthDay="1758-4-28",BirthPlace="Westmoreland Co., Va.",DeathDay="1831-7-4",DeathPlace="New York, New York"},
            new PresidentModel(){President="John Quincy Adams",BirthDay="1767-7-11",BirthPlace="Quincy, Mass.",DeathDay="1848-2-23",DeathPlace="Washington, D.C."},
            new PresidentModel(){President="Andrew Jackson",BirthDay="1767-3-15",BirthPlace="Waxhaws, No./So. Carolina",DeathDay="1845-6-8",DeathPlace="Nashville, Tennessee"},
            new PresidentModel(){President="Martin Van Buren",BirthDay="1782-12-5",BirthPlace="Kinderhook, New York",DeathDay="1862-7-24",DeathPlace="Kinderhook, New York"},
            new PresidentModel(){President="William Henry Harrison",BirthDay="1773-2-9",BirthPlace="Charles City Co., Va.",DeathDay="1841-4-4",DeathPlace="Washington, D.C."},
            new PresidentModel(){President="John Tyler",BirthDay="1790-3-29",BirthPlace="Charles City Co., Va.",DeathDay="1862-1-18",DeathPlace="Richmond, Va."},
            new PresidentModel(){President="James K. Polk",BirthDay="1795-11-2",BirthPlace="Mecklenburg Co., N.C.",DeathDay="1849-6-15",DeathPlace="Nashville, Tennessee"},
            new PresidentModel(){President="Zachary Taylor",BirthDay="1784-11-24",BirthPlace="Orange County, Va.",DeathDay="1850-7-9",DeathPlace="Washington, D.C"},
            new PresidentModel(){President="Millard Fillmore",BirthDay="1800-1-7",BirthPlace="Cayuga Co., New York",DeathDay="1874-3-8",DeathPlace="Buffalo, New York"},
            new PresidentModel(){President="Franklin Pierce",BirthDay="1804-11-23",BirthPlace="Hillsborough, N.H.",DeathDay="1869-10-8",DeathPlace="Concord, New Hamp."},
            new PresidentModel(){President="James Buchanan",BirthDay="1791-4-23",BirthPlace="Cove Gap, Pa.",DeathDay="1868-6-1",DeathPlace="Lancaster, Pa."},
            new PresidentModel(){President="Abraham Lincoln",BirthDay="1809-2-12",BirthPlace="LaRue Co., Kentucky",DeathDay="1865-4-15",DeathPlace="Washington, D.C."},
            new PresidentModel(){President="Andrew Johnson",BirthDay="1808-12-29",BirthPlace="Raleigh, North Carolina",DeathDay="1875-7-31",DeathPlace="Elizabethton, Tenn."},
            new PresidentModel(){President="Ulysses S. Grant",BirthDay="1822-4-27",BirthPlace="Point Pleasant, Ohio",DeathDay="1885-7-23",DeathPlace="Wilton, New York"},
            new PresidentModel(){President="Rutherford B. Hayes",BirthDay="1822-10-4",BirthPlace="Delaware, Ohio",DeathDay="1893-1-17",DeathPlace="Fremont, Ohio"},
            new PresidentModel(){President="James A. Garfield",BirthDay="1831-11-19",BirthPlace="Cuyahoga Co., Ohio",DeathDay="1881-9-19",DeathPlace="Elberon, New Jersey"},
            new PresidentModel(){President="Chester Arthur",BirthDay="1829-10-5",BirthPlace="Fairfield, Vermont",DeathDay="1886-11-18",DeathPlace="New York, New York"},
            new PresidentModel(){President="Grover Cleveland",BirthDay="1837-3-18",BirthPlace="Caldwell, New Jersey",DeathDay="1908-6-24",DeathPlace="Princeton, New Jersey"},
            new PresidentModel(){President="Benjamin Harrison",BirthDay="1833-8-20",BirthPlace="North Bend, Ohio",DeathDay="1901-3-13",DeathPlace="Indianapolis, Indiana"},
            new PresidentModel(){President="William McKinley",BirthDay="1843-1-29",BirthPlace="Niles, Ohio",DeathDay="1901-9-14",DeathPlace="Buffalo, New York"},
            new PresidentModel(){President="Theodore Roosevelt",BirthDay="1858-10-27",BirthPlace="New York, New York",DeathDay="1919-1-6",DeathPlace="Oyster Bay, New York"},
            new PresidentModel(){President="William Howard Taft",BirthDay="1857-9-15",BirthPlace="Cincinnati, Ohio",DeathDay="1930-3-8",DeathPlace="Washington, D.C."},
            new PresidentModel(){President="Woodrow Wilson",BirthDay="1856-12-28",BirthPlace="Staunton, Virginia",DeathDay="1924-2-3",DeathPlace="Washington, D.C."},
            new PresidentModel(){President="Warren G. Harding",BirthDay="1865-11-2",BirthPlace="Morrow County, Ohio",DeathDay="1923-8-2",DeathPlace="San Francisco, Cal."},
            new PresidentModel(){President="Calvin Coolidge",BirthDay="1872-7-4",BirthPlace="Plymouth, Vermont",DeathDay="1933-1-5",DeathPlace="Northampton, Mass."},
            new PresidentModel(){President="Herbert Hoover",BirthDay="1874-8-10",BirthPlace="West Branch, Iowa",DeathDay="1964-10-20",DeathPlace="New York, New York"},
            new PresidentModel(){President="Franklin Roosevelt",BirthDay="1882-1-30",BirthPlace="Hyde Park, New York",DeathDay="1945-4-12",DeathPlace="Warm Springs, Georgia"},
            new PresidentModel(){President="Harry S. Truman",BirthDay="1884-5-8",BirthPlace="Lamar, Missouri",DeathDay="1972-12-26",DeathPlace="Kansas City, Missouri"},
            new PresidentModel(){President="Dwight Eisenhower",BirthDay="1890-10-14",BirthPlace="Denison, Texas",DeathDay="1969-3-28",DeathPlace="Washington, D.C."},
            new PresidentModel(){President="John F. Kennedy",BirthDay="1917-5-29",BirthPlace="Brookline, Mass.",DeathDay="1963-11-22",DeathPlace="Dallas, Texas"},
            new PresidentModel(){President="Lyndon B. Johnson",BirthDay="1908-8-27",BirthPlace="Gillespie Co., Texas",DeathDay="1973-1-22",DeathPlace="Gillespie Co., Texas"},
            new PresidentModel(){President="Richard Nixon",BirthDay="1913-1-9",BirthPlace="Yorba Linda, Cal.",DeathDay="1994-4-22",DeathPlace="New York, New York"},
            new PresidentModel(){President="Gerald Ford",BirthDay="1913-7-14",BirthPlace="Omaha, Nebraska",DeathDay="2006-12-26",DeathPlace="Rancho Mirage, Cal."},
            new PresidentModel(){President="Jimmy Carter",BirthDay="1924-10-1",BirthPlace="Plains, Georgia",DeathDay="",DeathPlace=""},
            new PresidentModel(){President="Ronald Reagan",BirthDay="1911-2-6",BirthPlace="Tampico, Illinois",DeathDay="2004-6-5",DeathPlace="Los Angeles, Cal."},
            new PresidentModel(){President="George Bush",BirthDay="1924-6-12",BirthPlace="Milton, Mass.",DeathDay="",DeathPlace=""},
            new PresidentModel(){President="Bill Clinton",BirthDay="1946-8-19",BirthPlace="Hope, Arkansas",DeathDay="",DeathPlace=""},
            new PresidentModel(){President="George W. Bush",BirthDay="1646-7-6",BirthPlace="New Haven, Conn.",DeathDay="",DeathPlace=""},
            new PresidentModel(){President="Barack Obama",BirthDay="1961-8-4",BirthPlace="Honolulu, Hawaii",DeathDay="",DeathPlace=""},
            new PresidentModel(){President="Donald Trump",BirthDay="1946-6-14",BirthPlace="New York, New York",DeathDay="",DeathPlace=""}

        };

        [HttpGet]
        public IEnumerable<PresidentModel> Get()
        {
            return presidents;
        }

        [HttpGet("{sorted}",Name = "GetSorted")]
        public IEnumerable<PresidentModel> Get(string sorted)
        {
            switch (sorted)
            {
                case "asc":
                    return presidents.OrderBy(x => x.President);                    
                case "desc":
                    return presidents.OrderByDescending(x => x.President);                    
                default:
                    return presidents;                    
            }
            
        }
    }

}