document.write('<link href="https://cdn.jsdelivr.net/npm/bootstrap@5.3.0/dist/css/bootstrap.min.css" rel="stylesheet" integrity="sha384-9ndCyUaIbzAi2FUVXJi0CjmCapSmO7SnpJef0486qhLnuZ2cdeRhO02iuK6FUUVM" crossorigin="anonymous">\
<script src="https://ajax.googleapis.com/ajax/libs/jquery/3.6.4/jquery.min.js"></script>\
<script src="https://cdn.jsdelivr.net/npm/bootstrap@5.3.0/dist/js/bootstrap.bundle.min.js" integrity="sha384-geWF76RCwLtnZ8qwWowPQNguL3RmwHVBC9FhGdlKrxdiJJigb/j/68SIy3Te4Bkz" crossorigin="anonymous"></script>\
<script>function search(){ console.log("da ajunge");var termen=document.getElementById("input").value;\
if(termen.toLowerCase().includes("menu") || termen.toLowerCase().includes("product") ||  termen.toLowerCase().includes("dishes")) \
{window.location="produse/Produse.Html"}\
 else\
 {\
 if(termen.toLowerCase().includes("com") || termen.toLowerCase().includes("raport"))\
 window.location="comenzi/Comenzi.Html"\
}}\
</script>\
<div width="100vw">\
<nav class="navbar  navbar-expand-lg navbar-light bg-light ">\
  <a class="navbar-brand" href="Home.html">Restaurant Oldies</a>\
    <div  class=" collapse navbar-collapse"  id="navbarSupportedContent">\
    <ul class="navbar-nav mr-auto">\
      <li class="nav-item active">\
        <a class="nav-link" href="Home.html">Home <span class="sr-only">(current)</span></a>\
      </li>\
      <li class="nav-item">\
        <a class="nav-link" href="https://localhost:7094/Identity/Account/Login">Login</a>\
      </li>\
<li class="nav-item">\
        <a class="nav-link"  onclick="logout()" href="#">Logout</a>\
      </li>\
       <li class="nav-item">\
	    <a class="nav-link" href="produse/Produse.html">Menu</a>\
      </li>\
  <li class="nav-item">\
	    <a class="nav-link" href="comenzi/Comenzi.html">Comenzi si Rapoarte</a>\
	  </li>\
  </div>\
  <br>\
    <form class="form-inline my-2 my-lg-0">\
      <input class="form-control mr-sm-2" id="input" type="search" placeholder="Search" aria-label="Search">\
    </form>\
	 <button class="btn btn-outline-success my-2 my-sm-0" onclick="search()" >Search</button>\
</nav>\
</div> \
')