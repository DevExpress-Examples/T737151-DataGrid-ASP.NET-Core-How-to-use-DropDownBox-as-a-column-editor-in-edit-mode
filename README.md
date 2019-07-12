# ASP.NET Core DataGrid - How to use DropDownBox as a column editor in edit mode
<!-- default file list -->
*Files to look at*:

* [DataController.cs](./CS/CS/Controllers/DataController.cs) 
* [DxDropDownBox.cshtml](./CS/CS/Views/Home/DxDropDownBox.cshtml)
* [Index.cshtml](./CS/CS/Views/Home/Index.cshtml)
<!-- default file list end -->

<p>This example illustrates how to define <a href="https://js.devexpress.com/Documentation/ApiReference/UI_Widgets/dxDropDownBox/">dxDropDownBox</a> with an embedded <a href="https://js.devexpress.com/Documentation/ApiReference/UI_Widgets/dxDataGrid/">dxDataGrid</a> for editing data in ASP.NET Core via an <a href="https://js.devexpress.com/Documentation/ApiReference/UI_Widgets/dxDataGrid/Configuration/columns/#editCellTemplate">EditCellTemplate</a>. Run the example and check the State column to see this approach in action.<br>


<h3>Description</h3>

<p>Perform the following steps to complete this task:&nbsp;</p>
<p>1.&nbsp;Use&nbsp;<a href="https://js.devexpress.com/Documentation/ApiReference/UI_Widgets/dxDataGrid/Configuration/columns/#editCellTemplate">EditCellTemplate</a>&nbsp;to define MVC DropDownBox for a required column.<br>2.&nbsp;&nbsp;Implement the&nbsp;<a href="https://js.devexpress.com/Documentation/ApiReference/UI_Widgets/dxDropDownBox/Configuration/#contentTemplate">Template</a>&nbsp;function to define MVC DataGrid&nbsp;and handle its&nbsp;<a href="https://js.devexpress.com/Documentation/ApiReference/UI_Widgets/dxDataGrid/Configuration/#onSelectionChanged">selectionChanged</a>&nbsp;event to pass selected keys to DropDownBox. In addition, handle the&nbsp;<a href="https://js.devexpress.com/Documentation/ApiReference/UI_Widgets/dxDropDownBox/Configuration/#onValueChanged">dxDropDownBox.valueChanged</a>&nbsp;event&nbsp;to adjust the DataGrid selection<br>3. Use&nbsp;<a href="https://js.devexpress.com/Documentation/ApiReference/UI_Widgets/dxDataGrid/Configuration/columns/#cellTemplate">CellTemplate</a>&nbsp;to covert an array of selected keys to a human-readable text.<br><br>For more information about MVC templates, please review the&nbsp;<a href="https://docs.devexpress.com/AspNetCore/401029/devextreme-based-controls/concepts/templates">Templates</a>&nbsp;help topic.</p>

<br/>


