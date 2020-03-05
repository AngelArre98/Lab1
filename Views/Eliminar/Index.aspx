<%@ Page Language="C#" Inherits="System.Web.Mvc.ViewPage<dynamic>" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <title>Eliminar Video</title>
</head>
<body>
    <h1>Eliminar Videos</h1>

    <form action ="/Eliminar/Index/" method = "post">
    <fieldset> 
    <legend>Eliminar videos</legend>
   
    <label for ="IdVideo">Id del video </label>
    <input type ="text" name = "IdVideo"/>

    <input  type="submit" value = "Eliminar"/>
    
    
    </fieldset>
    
    
    
    
    
    
    </form>
</body>
</html>
