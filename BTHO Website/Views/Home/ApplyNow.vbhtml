@Code
    ViewData("Title") = "Bridge to Homeownership - Apply Now"
End Code
<script src="https://getaddress.io/js/jquery.getAddress-2.0.7.min.js"></script>
<div class="scroll_section" id="home_1">


    <h1>Apply Now</h1>
    <p>Dapibus Vehicula Ipsum Inceptos Nibh</p>


</div>


<div class="scroll_section" id="home_2">
    <h2 style="color: #007fb6;">Apply Now</h2>
    @*<ul class="fancy">
        <li><span>Integer posuere erat a ante venenatis dapibus posuere velit aliquet.</span></li>
        <li><span>Sed posuere consectetur est at lobortis.</span></li>
        <li><span>Integer posuere erat a ante venenatis dapibus posuere velit aliquet.</span></li>
        <li><span>Cras justo odio, dapibus ac facilisis in, egestas eget quam.</span></li>
        <li><span>Aenean eu leo quam. Pellentesque ornare sem lacinia quam venenatis vestibulum.</span></li>
    </ul>*@



    <form class="form-horizontal">
        <div class="form-group">
            <label for="inputTtile" class="col-sm-offset-3 col-sm-2 control-label">Title</label>
            <div class="col-sm-2">
                <select class="form-control" id="inputTtile">
                    <option>Mr</option>
                    <option>Mrs</option>
                    <option>Miss</option>
                    <option>Ms</option>
                </select>
            </div>
        </div>
        <div class="form-group">
            <label for="inputFirstName" class="col-sm-offset-3 col-sm-2 control-label">First Name</label>
            <div class="col-sm-3">
                <input type="text" class="form-control" id="inputFirstName" placeholder="First Name">
            </div>
        </div>
        <div class="form-group">
            <label for="inputSurname" class="col-sm-offset-3 col-sm-2 control-label">Surname</label>
            <div class="col-sm-3">
                <input type="text" class="form-control" id="inputSurname" placeholder="Surname">
            </div>
        </div>
        <br />
        <div class="form-group">
            <label for="postcode_lookup" class="col-sm-offset-3 col-sm-2 control-label">Your Postcode</label>
            <div class="col-sm-3" id="postcode_lookup">

            </div>
        </div>

        @*<div id="postcode_lookup"></div>*@ 

        <div class="form-group">
            <label for="inputAdd1" class="col-sm-offset-3 col-sm-2 control-label">Address Line 1</label>
            <div class="col-sm-3">
                <input type="text" class="form-control" id="inputAdd1" placeholder="Address Line 1">
            </div>
        </div>
        <div class="form-group">
            <label for="inputAdd2" class="col-sm-offset-3 col-sm-2 control-label">Address Line 2</label>
            <div class="col-sm-3">
                <input type="text" class="form-control" id="inputAdd2" placeholder="Address Line 2">
            </div>
        </div>
        <div class="form-group">
            <label for="inputAdd3" class="col-sm-offset-3 col-sm-2 control-label">Address Line 3</label>
            <div class="col-sm-3">
                <input type="text" class="form-control" id="inputAdd3" placeholder="Address Line 3">
            </div>
        </div>
        <div class="form-group">
            <label for="inputTown" class="col-sm-offset-3 col-sm-2 control-label">Town</label>
            <div class="col-sm-3">
                <input type="text" class="form-control" id="inputTown" placeholder="Town">
            </div>
        </div>
        <div class="form-group">
            <label for="inputCounty" class="col-sm-offset-3 col-sm-2 control-label">County</label>
            <div class="col-sm-3">
                <input type="text" class="form-control" id="inputCounty" placeholder="County">
            </div>
        </div>
        <div class="form-group">
            <label for="inputPostcode" class="col-sm-offset-3 col-sm-2 control-label">Postcode</label>
            <div class="col-sm-3">
                <input type="text" class="form-control" id="inputPostcode" placeholder="Postcode">
            </div>
        </div>


 
        <div class="form-group">
            <div class="col-sm-offset-5 col-sm-3">
                <button type="submit" class="btn btn-default">Apply</button>
            </div>
        </div>
    </form>

</div>
<div class="scroll_section" id="home_3">
    <h2 class="outlined">Why Choose Us?</h2>
    <p>Etiam porta sem malesuada magna mollis euismod. Cras mattis consectetur purus sit amet fermentum.</p>
    <p>Duis mollis, est non commodo luctus, nisi erat porttitor ligula, eget lacinia odio sem nec elit. Aenean eu leo quam. Pellentesque ornare sem lacinia quam venenatis vestibulum. Cras mattis consectetur purus sit amet fermentum.</p>
    <p>Aenean lacinia bibendum nulla sed consectetur. Donec ullamcorper nulla non metus auctor fringilla.</p>
    <a class="btn" href="#">Apply Now</a>
</div>



<!-- Add after your form -->
<script>
$('#postcode_lookup').getAddress({
    api_key: 'IkNU43_RoUO1OEEEKxnEAQ1623',
   
    output_fields:{
        line_1: '#inputAdd1',
        line_2: '#inputAdd2',
        line_3: '#inputAdd3',
        post_town: '#inputTown',
        county: '#inputCountry',
        postcode: '#inputPostcode'
    },
    input_class: "form-control",
    button_class: "btn",
    dropdown_class: "form-control"
//<!--  Optionally register callbacks at specific stages -->
//    onLookupSuccess: function(data){/* Your custom code */},
//    onLookupError: function(){/* Your custom code */},
//    onAddressSelected: function(elem,index){/* Your custom code */}
});
</script>