
/*
  TUavatarLoaded : Global variable to tell if avatar is loaded or not

  This will be set to TRUE in allcsa.js after the avatar
  would have loaded successfully
*/
var TUavatarLoaded = false;

/*
  avatarbusy : Binary lock variable to be checked before
  giving control to next word to be played  
*/
var avatarbusy = false;

/*
  weblog function to write into the debugger area of the
  avatar
*/
function weblog(line)
{
    weblogid = document.getElementById("debugger");
    weblogid.innerHTML=line+"<br>"+weblogid.innerHTML;
}
