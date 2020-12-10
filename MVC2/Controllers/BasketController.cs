using AutoMapper;
using BusinessLogic;
using DTO;
using MVC2.App.Security;
using MVC2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVC2.Controllers
{
    public class BasketController:Controller
    {
        protected readonly ICustomer _customer;
        protected readonly IMapper _mapper;

        public BasketController(ICustomer customer, IMapper mapper)
        {
            _customer = customer;
            _mapper = mapper;
        }

        // GET: Books
        public ActionResult Index(string t,string c)
        {
            var movies = _customer.FindBook(t,c);
            return View(_mapper.Map<List<BasketDetailsModel>>(movies));
        }

        public ActionResult Details(int id)
        {
            return View();
        }

        [CustomAuthorize(Roles = "Customer")]

        public ActionResult Create()
        {
            var insertModel = new EditBasketModel();
            return View(insertModel);
        }

        [CustomAuthorize(Roles = "Customer")]

       [HttpPost]
        public ActionResult Create(EditBasketModel model)
        {
            try
            {

                if (ModelState.IsValid)
                {

                    _customer.AddBasket(_mapper.Map<BasketDTO>(model));
                    return RedirectToAction("Index");
                }

                return View(model);
            }
            catch (Exception ex)
            {
                ModelState.AddModelError(string.Empty, $"An exception has occurred: {ex}");

                return View(model);
            }
        }


        [CustomAuthorize(Roles = "Customer")]
        public ActionResult Edit(int id)
        {
            var basketById = _customer.GetBasket2(id);
            var editModel = _mapper.Map<EditBasketModel>(basketById);

            return View(editModel);
        }

        [CustomAuthorize(Roles = "Customer")]
        [HttpPost]
        public ActionResult Edit(int id1, int id2,EditBasketModel model)
        {
            try
            {
                if (ModelState.IsValid)
                {

                    _customer.UpdateStatus(id1,id2);
                    return RedirectToAction("Index");
                }

                return View(model);
            }
            catch (Exception ex)
            {
                ModelState.AddModelError(string.Empty, $"An exception has occurred: {ex}");

                return View(model);
            }
        }

        [CustomAuthorize(Roles = "Customer")]
        public ActionResult Delete(int id)
        {
            return View();
        }

        [CustomAuthorize(Roles = "Customer")]
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {

             //   _customer.DeleteBasketById(id);
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}