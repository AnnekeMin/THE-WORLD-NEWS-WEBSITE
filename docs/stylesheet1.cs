/ Style the tab /
.tab {
overflow: hidden;
border: 1px solid #B0C4DE;
background-color: #B0C4DE;
}

.tab button {
background-color: #B0C4DE;
float: center;
border: #B0C4DE;
/* border-color: #C0C0C0; */
border-spacing: 20px;
outline: none;
cursor: pointer;
padding: 14px 16px;
transition: 0.3s;
font-size: 18px;
align-content: center;
font-family: courier New, monospace;

/* font-weight: bold; */
}

/* .tabcontent {
display: none;
padding: 6px 12px;
border: 1px solid #BBB;
border-top: none;
} */
/ Change background color of buttons on hover /
.tab button:hover {
background-color: #B0C4DE;
}

/ Create an active/current tablink class /
.tab button.active {
background-color: #B0C4DE;
}

/* / Style the tab content /
.tabcontent {
display: none;
padding: 6px 12px;
border: 1px solid #ccc;
border-top: none;
align-content: center;
font-family: comic sans-serif, cursive;
} */
.btn-group button{
  background-color: #A1F3F1;
  border: 1px solid lightblue;
  float:center;
  color: black;
  padding: 10px 24px;
  cursor:pointer;
  align-content: center;
  font-family: Jaz LET,cursive;
  font-size: 16px;
  font-weight: bold;

}
.btn-group: after{
  content: "";
  clear:both;
  display: table;

}
.btn-group button: hover {
  background-color:#99b6c9;
}
.footer{
  position:relative;
  left:0;
  bottom:0;
  width:100%;
  background-color:lightblue;
  color:black;
  text-align:center;
}
/* .btncontent {
  display: none;
  padding: 6px 12px;
  border: 1px solid #ccc;
  border-top: none;
  align-content: center;
  font-family: comic sans-serif, cursive;
} */

p {
text-indent: 50px}

p.exl {
  direction: rtl;
}
#TheWorldNews {
  font-family:Lucida Console, monospace;
  text-align: center;
  letter-spacing: 3px;
  word-spacing: 10px;
  font-weight:bold;
  font-size: 50px
}
#Tabs {
  overflow: scroll;
  /* border: 1px solid #B0C4DE; */
  background-color:#F0F8FF;
  text-align: center;
}

#Home {
  font-size:20px;
  text-align: center;
  font-weight:bold;
  letter-spacing: 3px;
  word-spacing: 10px;
  font-family:comic Sans-serif, fantasy;
  background-color: #F0F8FF;
}

#LocalNews {
  font-family: Jaz LET, cursive;
  font-size: 50px;
  font-weight: bold;
  text-align: center;
  letter-spacing: 3px;
  word-spacing: 10px;
  background-image: url("light.jpg")

}

#GlobalNews {
  font-family: comic sans-serif, cursive;
  text-align: center;
  letter-spacing: 3px;
  word-spacing: 10px;
  background-image: url("globalbackground.jpg")
}

#Weather {
  font-family: comic sans-serif,cursive;
  text-align: center;
  letter-spacing: 3px;
  word-spacing: 20px;
  background-image: url("clouds.jpg")
}

#Entertainment {
  font-family: comic sans-serif, cursive;
  text-align: center;
  letter-spacing: 3px;
  word-spacing: 10px;
  background-image: url("Unknown-.png")
}

#AboutUs {
  font-family: comic sans-serif, cursive;
  text-align: center;
  letter-spacing: 3px;
  word-spacing: 10px;
  font-size: 18px;
}
#btn-group{
  margin:auto;
  display:flex;
  flex-direction: row;
  justify-content:center;
  align-content: center;
}

#name {
  text-align: center;
  letter-spacing: 3px;
  word-spacing: 10px;
  font-size: 50px;
  font-weight: bold;
  font-style: underline;
}
