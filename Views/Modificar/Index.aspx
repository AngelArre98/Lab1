<%@ Page Language="C#" Inherits="System.Web.Mvc.ViewPage<dynamic>" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml" >
<head runat="server">
    <title>Modificar Videos</title>
</head>
<body>
    <h1>Modificar Videos</h1>

    <form action ="/Modificar/Index" method ="post"> 
    <fieldset>
    <legend>Modificar Video</legend>

    <lebel for="IdVideo">Id del Video a Modificar</lebel>
    <input type ="text" name ="IdVideo" />

    <lebel for="titulo">Titulo</lebel>
    <input type="text" name ="titulo" />

    <lebel for="repro">Reproducciones</lebel>
    <input type ="text" name ="repro"/>

    <lebel for ="url">URL</lebel>
    <input type="text" name="url" />




    <input type="submit" value ="Modificar" />
    
    
    
    
    
    
    </fieldset>
    
    
    </form>
</body>
</html>
