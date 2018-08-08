using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Http;
using System.Web.Http.Controllers;
using System.Web.Http.ModelBinding;
using System.Web.Http.OData;
using System.Web.Http.OData.Routing;
using System.Web.Http.Results;
using CreateAndFake;
using ODataFx;

// https://createandfake.github.io/CreateAndFake/

namespace ODataFx.Controllers
{
    /*
    The WebApiConfig class may require additional changes to add a route for this controller. Merge these statements into the Register method of the WebApiConfig class as applicable. Note that OData URLs are case sensitive.

    using System.Web.Http.OData.Builder;
    using System.Web.Http.OData.Extensions;
    using ODataFx;
    ODataConventionModelBuilder builder = new ODataConventionModelBuilder();
    builder.EntitySet<Person>("People");
    config.Routes.MapODataServiceRoute("odata", "odata", builder.GetEdmModel());
    */
    public class PeopleController : ODataController
    {
        //private Repository db = new Repository();

        // GET: odata/People
        // GET: odata/People?$top=10&$skip=20
        // GET: odata/People?$filter=Name eq 'Bnaya'
        [EnableQuery(PageSize = 10)]
        public IQueryable<Person> GetPeople()
        {
            var query = from i in Enumerable.Range(0, 1000)
                        select Tools.Randomizer.Create<Person>();
            return query.AsQueryable();
        }


        //[EnableQuery]
        //public IQueryable<Person> GetPeople()
        //{
        //    return db.People;
        //}

        //// GET: odata/People(5)
        //[EnableQuery]
        //public SingleResult<Person> GetPerson([FromODataUri] int key)
        //{
        //    return SingleResult.Create(db.People.Where(person => person.Id == key));
        //}

        //// PUT: odata/People(5)
        //public async Task<IHttpActionResult> Put([FromODataUri] int key, Delta<Person> patch)
        //{
        //    Validate(patch.GetEntity());

        //    if (!ModelState.IsValid)
        //    {
        //        return BadRequest(ModelState);
        //    }

        //    Person person = await db.People.FindAsync(key);
        //    if (person == null)
        //    {
        //        return NotFound();
        //    }

        //    patch.Put(person);

        //    try
        //    {
        //        await db.SaveChangesAsync();
        //    }
        //    catch (DbUpdateConcurrencyException)
        //    {
        //        if (!PersonExists(key))
        //        {
        //            return NotFound();
        //        }
        //        else
        //        {
        //            throw;
        //        }
        //    }

        //    return Updated(person);
        //}

        //// POST: odata/People
        //public async Task<IHttpActionResult> Post(Person person)
        //{
        //    if (!ModelState.IsValid)
        //    {
        //        return BadRequest(ModelState);
        //    }

        //    db.People.Add(person);
        //    await db.SaveChangesAsync();

        //    return Created(person);
        //}

        //// PATCH: odata/People(5)
        //[AcceptVerbs("PATCH", "MERGE")]
        //public async Task<IHttpActionResult> Patch([FromODataUri] int key, Delta<Person> patch)
        //{
        //    Validate(patch.GetEntity());

        //    if (!ModelState.IsValid)
        //    {
        //        return BadRequest(ModelState);
        //    }

        //    Person person = await db.People.FindAsync(key);
        //    if (person == null)
        //    {
        //        return NotFound();
        //    }

        //    patch.Patch(person);

        //    try
        //    {
        //        await db.SaveChangesAsync();
        //    }
        //    catch (DbUpdateConcurrencyException)
        //    {
        //        if (!PersonExists(key))
        //        {
        //            return NotFound();
        //        }
        //        else
        //        {
        //            throw;
        //        }
        //    }

        //    return Updated(person);
        //}

        //// DELETE: odata/People(5)
        //public async Task<IHttpActionResult> Delete([FromODataUri] int key)
        //{
        //    Person person = await db.People.FindAsync(key);
        //    if (person == null)
        //    {
        //        return NotFound();
        //    }

        //    db.People.Remove(person);
        //    await db.SaveChangesAsync();

        //    return StatusCode(HttpStatusCode.NoContent);
        //}

        //protected override void Dispose(bool disposing)
        //{
        //    if (disposing)
        //    {
        //        db.Dispose();
        //    }
        //    base.Dispose(disposing);
        //}

        //private bool PersonExists(int key)
        //{
        //    return db.People.Count(e => e.Id == key) > 0;
        //}
    }
}
