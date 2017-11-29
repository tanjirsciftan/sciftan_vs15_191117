using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using SCIFTAN.BLL.Models;
using SCIFTAN.DAL.DB.EF;
using SCIFTAN.BLL.IService;
using Microsoft.AspNet.Identity;
using System.IO;

namespace SCIFTAN.Controllers
{
    public class FreelancerDocController : Controller
    {
        private readonly IFreelancerDocService _iFreelancerDocService;

        public FreelancerDocController(IFreelancerDocService iFreelancerDocService)
        {
            _iFreelancerDocService = iFreelancerDocService;
        }


        public ActionResult Index()
        {
            FREELANCER_DOC_INFO_Model doc = null;
            if (User.Identity.GetUserId() != null)
            {
                doc = _iFreelancerDocService.GetFreelancerDocById(User.Identity.GetUserId());
            }
            return View(doc);
        }
        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(HttpPostedFileBase photo, HttpPostedFileBase nid, HttpPostedFileBase pvc)
        {

            FREELANCER_DOC_INFO_Model fREELANCER_DOC_INFO_Model = new FREELANCER_DOC_INFO_Model();
            fREELANCER_DOC_INFO_Model.Freelancer_Id = User.Identity.GetUserId();

            if (photo != null)
            {
                string ext = Path.GetExtension(photo.FileName);
                if (ext == ".jpg" || ext == ".png")
                {
                    string photoPath = Path.Combine(Server.MapPath("~/UploadFiles/"), Path.GetFileName(User.Identity.GetUserId() + "_photo"+ ext));
                    photo.SaveAs(photoPath);
                    fREELANCER_DOC_INFO_Model.Picture_Path = "~/UploadFiles/" + User.Identity.GetUserId() + "_photo" + ext;
                }
                else
                {
                    ViewBag.ValidationMsg = "File Extension of Photo Should be .jpg or .png";
                    return RedirectToAction("Create");
                }
            }
            if (nid != null)
            {
                string ext = Path.GetExtension(nid.FileName);
                if (ext == ".jpg" || ext == ".png")
                {
                    string nidPath = Path.Combine(Server.MapPath("~/UploadFiles/"), Path.GetFileName(User.Identity.GetUserId() + "_nid" + ext));
                    nid.SaveAs(nidPath);
                    fREELANCER_DOC_INFO_Model.NID_Path = "~/UploadFiles/" + User.Identity.GetUserId() + "_nid" + ext;
                }
                else
                {
                    ViewBag.ValidationMsg = "File Extension of NID Should be .jpg or .png";
                    return RedirectToAction("Create");
                }
            }
            if (pvc != null)
            {
                string ext = Path.GetExtension(pvc.FileName);
                if (ext == ".jpg" || ext == ".png")
                {
                    string pvcPath = Path.Combine(Server.MapPath("~/UploadFiles/"), Path.GetFileName(User.Identity.GetUserId() + "_pvc" + ext));
                    pvc.SaveAs(pvcPath);
                    fREELANCER_DOC_INFO_Model.PVC_Path = "~/UploadFiles/" + User.Identity.GetUserId() + "_pvc" + ext;
                }
                else
                {
                    ViewBag.ValidationMsg = "File Extension of PVC Should be .jpg or .png";
                    return RedirectToAction("Create");
                }
            }


            if (_iFreelancerDocService.InsertFreelancerDoc(fREELANCER_DOC_INFO_Model))
            {
                return RedirectToAction("Create");
            }


            return View(fREELANCER_DOC_INFO_Model);
        }


        public ActionResult Edit(string id)
        {
            if (User.Identity.GetUserId() == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            FREELANCER_DOC_INFO_Model fREELANCER_DOC_INFO_Model = _iFreelancerDocService.GetFreelancerDocById(User.Identity.GetUserId());
            if (fREELANCER_DOC_INFO_Model == null)
            {
                return HttpNotFound();
            }
            return View(fREELANCER_DOC_INFO_Model);
        }


        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Freelancer_Id,NID_Path,Picture_Path,PVC_Path")] FREELANCER_DOC_INFO_Model fREELANCER_DOC_INFO_Model)
        {
            if (ModelState.IsValid)
            {
                if (_iFreelancerDocService.UpdateFreelancerDoc(fREELANCER_DOC_INFO_Model))
                {
                    return RedirectToAction("Index");
                }
            }
            return View(fREELANCER_DOC_INFO_Model);
        }


        public ActionResult Delete(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            _iFreelancerDocService.DeleteFreelancerDoc(id);
            return RedirectToAction("Index");
        }


    }
}
