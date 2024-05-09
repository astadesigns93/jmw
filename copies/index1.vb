<!doctype html>
<html lang="en">
  <head>
    <title>Webb's Portfolio</title>
    <!--links-->
    <meta charset="utf-8">
      <meta http-equiv="X-UA-Compatible" content="IE=edge">
        <meta name="viewport" content="width=device-width, initial-scale=1">
          <link href="https://cdn.jsdelivr.net/npm/bootstrap@5.3.0-alpha1/dist/css/bootstrap.min.css" rel="stylesheet" integrity="sha384-GLhlTQ8iRABdZLl6O3oVMWSktQOp6b7In1Zl3/Jr59b6EGGoI1aFkw7cmDA6j6gD" crossorigin="anonymous">
            <script src="https://cdn.jsdelivr.net/npm/bootstrap@5.3.0-alpha1/dist/js/bootstrap.bundle.min.js" integrity="sha384-w76AqPfDkMBDXo30jS1Sgez6pr3x5MlQ1ZAGC+nuZB+EYdgRZgiwxhTBTkF7CXvN" crossorigin="anonymous"></script>
            <link href="//netdna.bootstrapcdn.com/bootstrap/3.0.2/css/bootstrap.min.css" rel="stylesheet">
            </head>


            <body>
              <!-- Or let Bootstrap automatically handle the layout -->
              <main>
                <body background="image/gradient2.png">
                </body>
              </main>
              <header>
                <div class="bars" id="nav-action">
                  <span class="bar"></span>
                </div>
                <nav id="nav">
                  <ul>
                    <li class="shape-circle circle-one">
                      <a href="index1.html">Home</a>
                    </li>
                    <li class="shape-circle circle-two">
                      <a href="about.html">about</a>
                    </li>
                    <li class="shape-circle circle-three">
                      <a href="#">Contact</a>
                    </li>
                    <li class="shape-circle circle-five">
                      <a href="#">Komanda</a>
                    </li>
                    <li class="shape-circle circle-five">
                      <a href="#">Elaqe</a>
                    </li>
                  </ul>
                </nav>
              </header>
              <style>* {
  margin: 0;
  padding: 0;
}

body {
  position: relative;
  background-size: cover; 
  min-width: 500px;
  min-height: 200px;
  color: rgba(200,211,255,1.00);
  font-family: Gotham, 'Helvetica Neue', 'sans-serif'
  background-color: #111A20 !important;
  height:100vmax;
}

.bars {
  /*   background-color:lightblue; */
  position: absolute;
  width: 27px;
  height: 27px;
  top: 30px;
  right: 30px;
  cursor: pointer;
  z-index: 101;
  padding-top:9px;
}

.bar {
  width: 100%;
  height: 4px;
  background-color: #fff;
  position: absolute;
}

span::before,
span::after {
  content: "";
  display: block;
  background-color: #fff;
  width: 100%;
  height: 4px;
  position: absolute;
}

.bar::before {
  transform: translateY(-9px);
}

.bar::after {
  transform: translateY(9px);
}

.bars.active .bar {
  background-color: transparent;
}

.bars.active span::before {
  animation: top-bar 1s;
  animation-fill-mode: forwards;
}

.bars.active span::after {
  animation: bottom-bar 1s;
  animation-fill-mode: forwards;
}


/* Navbar Links CSS */

#nav {
  position: absolute;
  top: 0;
  bottom: 0;
  left: 0;
  right: 0;
  transition: all 1s;
  z-index: -1;
  overflow: hidden;
  opacity: 0;
}

#nav a {
  color: #fff;
  text-decoration: none;
  font-size: 20px;
  position: absolute;
  top: 0;
  bottom: 0;
  left: 0;
  right: 0;
  border-radius: 50%;
  transition: all .5s;
}

#nav a:hover {
  background: rgba(169,196,208,0.12);
  font-size: 25px;
  color:#708398;
}

ul {
  list-style: none;
}

.visible {
  z-index: 100 !important;
  opacity: 1 !important;
}

.shape-circle {
  border-radius: 50%;
  width: 20vw;
  height: 20vw;
  top: -10vw;
  right: -10vw;
  position: absolute;
  transition: all 1s ease-in-out;
  background: background-color: transparent;
  box-shadow: 0 0px 0px rgba(187,188,216,0.50);
}

nav.visible li:first-child {
  width: 200vw;
  height: 200vw;
  top: -100vw;
  right: -100vw;
  z-index: 5;
  transition: all .4s ease-in-out;
  box-shadow: 0 0px 50px #333333;
}

nav.visible li:nth-child(2) {
  width: 160vw;
  height: 160vw;
  top: -80vw;
  right: -80vw;
  z-index: 6;
  transition: all .5s ease-in-out;
  box-shadow: 0 0px 50px #333333;
}

nav.visible li:nth-child(3){
  width: 120vw;
  height: 120vw;
  top: -60vw;
  right: -60vw;
  z-index: 7;
  transition: all .6s ease-in-out;
  box-shadow: 0 0px 50px #333333;
}
nav.visible li:nth-child(4){
  width: 80vw;
  height: 80vw;
  top: -40vw;
  right: -40vw;
  z-index: 7;
  transition: all .7s ease-in-out;
  box-shadow: 0 0px 50px #333333;
}
nav.visible li:last-child{
  width: 40vw;
  height: 40vw;
  top: -20vw;
  right: -20vw;
  z-index: 8;
  transition: all .8s ease-in-out;
  box-shadow: 0 0px 50px #333333;
}

nav.visible li:first-child a {
  line-height: 280vw !important;
    text-indent: 14vw !important;

}

nav.visible li:nth-child(2) a {
  line-height: 220vw !important;
  text-indent:13vw !important;
}

nav.visible li:nth-child(3) a {
  line-height: 165vw !important;
    text-indent: 12vw !important;
  
}
nav.visible li:nth-child(4) a {
  line-height: 110vw !important;
    text-indent:11vw !important;
  
}
nav.visible li:last-child a {
  line-height: 60vw !important;
  text-indent:10vw !important;
}

@keyframes top-bar {
  50% {
    transform: translateY(0);
  }
  100% {
    transform: rotate(45deg) translateY(0);
  }
}

@keyframes bottom-bar {
  50% {
    transform: translateY(0);
  }
  100% {
    transform: rotate(-45deg) translateY(0);
  }
}
              </style>
              <script>// Setting up the Variables
var bars = document.getElementById("nav-action");
var nav = document.getElementById("nav");


//setting up the listener
bars.addEventListener("click", barClicked, false);


//setting up the clicked Effect
function barClicked() {
  bars.classList.toggle('active');
  nav.classList.toggle('visible');
}</script>
              <div class="footer">
                <p>Footer</p>
                <style>.footer {
   position: fixed;
   left: 0;
   bottom: 0;
   width: 100%;
   background-color: rgba(27,37,67,1.00);
   color: white;
   text-align: center;
}</style>
              </div>
            </body>
          </html>
