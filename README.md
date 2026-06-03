# DevOps Pipeline Monitor

A WPF desktop application built using C# and .NET 8 that simulates Jenkins and GitHub Actions CI/CD pipeline monitoring.

## Features

* Monitor Jenkins and GitHub Actions style pipelines
* Display Success, Failed, and Running pipeline states
* View pipeline execution logs
* Auto-refresh dashboard every 30 seconds
* Parse pipeline data using Newtonsoft.Json
* Color-coded status cards and dashboard metrics
* Desktop UI built with WPF

## Technologies Used

* C#
* WPF
* .NET 8
* Newtonsoft.Json
* JSON Data Processing

## Project Structure

* Models – Pipeline data models
* Services – Pipeline data loading and processing
* Data – Sample pipeline JSON data
* UI – WPF dashboard and monitoring views

## Use Case

This project demonstrates how CI/CD pipeline information can be visualized through a desktop dashboard. It simulates monitoring workflows commonly used with Jenkins and GitHub Actions and provides a foundation for integrating real REST APIs in the future.

## Future Enhancements

* Jenkins REST API integration
* GitHub Actions API integration
* Real-time pipeline notifications
* Historical pipeline analytics
* Multi-project monitoring support
