using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Xml.Linq;

namespace NotesApi.Controllers
{
    public class ReleaseController : ApiController
    {
        public List<Release> GetAllReleases()

        {
            List<Release> releases = new List<Release>();
            XDocument doc = XDocument.Load("C:\\Users\\ane\\Documents\\Visual Studio 2015\\Projects\\ReleaseNotes.xml");
            var x = doc.ToString();
            foreach (XElement element in doc./*Descendants("DocumentElement").*/Descendants("Release"))
            {
                Release release = new Release();
                release.Name = element.Element("name").Value;
                if (element.Element("News") != null)
                {
                    release.News = element.Element("News").Value;
                }
                if (element.Element("Bugs") != null)
                {
                    release.Bugs = element.Element("Bugs").Value;

                }
                releases.Add(release);
            }
            return releases;

        }

        //public Release GetRelease(int id)

        //{

        //    Release release = new Release();

        //    //XDocument doc = XDocument.Load("D:\\Mudita\\Employee.xml");
        //    XDocument doc = XDocument.Load("C: \\Users\\ane\\Documents\\Visual Studio 2015\\Projects\\ReleaseNotes.xml");

        //    XElement element = doc.Element("DocumentElement")

        //                        .Elements("Release").Elements("Name").

        //                        SingleOrDefault(x => x.Value == id.ToString());

        //    if (element != null)

        //    {

        //        XElement parent = element.Parent;

        //        release.Name =

        //                parent.Element("Name").Value;

        //        release.News =

        //                parent.Element("News").Value;

        //        release.Bugs =

        //                parent.Element("Bugs").Value;

        //        return release;

        //    }

        //    else

        //    {

        //        throw new HttpResponseException

        //            (new HttpResponseMessage(HttpStatusCode.NotFound));

        //    }

        //}

    }


}
