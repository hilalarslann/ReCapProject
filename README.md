# ReCapProject

      
        HomeController
        [HttpGet]
        public ActionResult ButtonAction()
        {
            string message = "Hoşgeldin Hilal";
            return new JsonResult() { Data = message, JsonRequestBehavior = JsonRequestBehavior.AllowGet };
        }

        [HttpPost]
        public ActionResult UserOperation(string userName)
        {
            string message = userName;
            return new JsonResult() { Data = message, JsonRequestBehavior = JsonRequestBehavior.AllowGet };
        }
        
        
        HTML KISMI
        <div class="row">
    <div class="col-sm-12">

        <input type="button" value="AllCustomer Butonu" onclick="location.href='@Url.Action("GetCustomerButton", "Home")'" />

        <input type="button" value="Login Butonu" onclick="location.href='@Url.Action("ButtonAction", "Home")'" />


        <br />
        <br />
  

        @using (Html.BeginForm("UserOperation", "Home", FormMethod.Post))
        {
            <input type="text" name="userName" id="userName" placeholder="Lütfen kullanıcı adı giriniz..." />
            <br />
            <input type="submit" value="Ekom Login" />
        }

    </div>
</div>
        
