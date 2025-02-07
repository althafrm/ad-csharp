using CityEvent.Business.Interfaces;
using CityEvent.Business.Services;
using CityEvent.Data.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CityEvent.Forms
{
    public partial class EventForm : Form
    {
        private readonly IEventService _eventService;

        public EventForm()
        {
            _eventService = new EventService();
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            var eventRequest = new EventModel();
            eventRequest.Name = txtName.Text;
            eventRequest.DateTime = dateTimePicker.Value;
            eventRequest.Venue = txtVenue.Text;
            eventRequest.Capacity = Convert.ToInt32(txtCapacity.Text);
            eventRequest.TicketPrice = Convert.ToDecimal(txtPrice.Text);
            eventRequest.Type = comboBox1.Text;

            _eventService.AddEvent(eventRequest);
            LoadEvents();
            MessageBox.Show("Event added successfully!");
        }

        private void EventForm_Load(object sender, EventArgs e)
        {
            LoadEvents();
        }
        private void LoadEvents()
        {
            var events = _eventService.GetAllEvents();
            dataGridView1.DataSource = events;
        }
    }
}
