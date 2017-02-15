<h1>E5171-How-to-bind-a-dashboard-to-a-List-object</h1>
The following example demonstrates how to bind a dashboard to a List object.

In this example, information about the sold units quantity is provided at runtime. The dashboard data source is added to the Dashboard.DataSources collection on the first load.

To update the displayed data, the DashboardViewer.ReloadData method is called. This raises the DashboardViewer.DataLoading event and allows supplying the dashboard with updated data.
