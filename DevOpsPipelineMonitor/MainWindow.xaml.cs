using DevOpsPipelineMonitor.Models;
using DevOpsPipelineMonitor.Services;
using System.Collections.Generic;
using System.Linq;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Threading;

namespace DevOpsPipelineMonitor
{
    public partial class MainWindow : Window
    {
        private readonly PipelineService pipelineService;
        private readonly DispatcherTimer refreshTimer;
        private List<PipelineStatus> pipelines;

        public MainWindow()
        {
            InitializeComponent();

            pipelineService = new PipelineService();
            pipelines = new List<PipelineStatus>();

            LoadPipelines();

            refreshTimer = new DispatcherTimer
            {
                Interval = TimeSpan.FromSeconds(30)
            };

            refreshTimer.Tick += RefreshTimer_Tick;
            refreshTimer.Start();
        }

        private void RefreshTimer_Tick(object? sender, EventArgs e)
        {
            LoadPipelines();
        }

        private void LoadPipelines()
        {
            pipelines = pipelineService.GetPipelines();

            PipelineDataGrid.ItemsSource = null;
            PipelineDataGrid.ItemsSource = pipelines;

            TotalText.Text = pipelines.Count.ToString();
            SuccessText.Text = pipelines.Count(p => p.Status == "Success").ToString();
            FailedText.Text = pipelines.Count(p => p.Status != "Success").ToString();
        }

        private void PipelineDataGrid_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (PipelineDataGrid.SelectedItem is PipelineStatus selectedPipeline)
            {
                MessageBox.Show(
                    selectedPipeline.Logs,
                    $"{selectedPipeline.PipelineName} Logs");
            }
        }
    }
}