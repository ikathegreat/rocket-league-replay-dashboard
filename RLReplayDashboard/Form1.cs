﻿using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using RocketLeagueReplayParser;
using RocketLeagueReplayParser.Serializers;

namespace RLReplayDashboard
{
    public partial class Form1 : Form
    {
        readonly ConcurrentBag<Replay> concurrentBagReplays = new ConcurrentBag<Replay>();
        readonly List<Replay> gridList = new List<Replay>();
        public Form1()
        {
            InitializeComponent();
            // This line of code is generated by Data Source Configuration Wizard
            gridControl1.DataSource = new System.ComponentModel.BindingList<RocketLeagueReplayParser.Replay>() /* TODO: Assign the real data here.*/;
        }

        private void buttonRead_Click(object sender, EventArgs e)
        {
            var files = Directory.GetFiles(textBoxReplayPath.Text, "*.replay", SearchOption.AllDirectories);

            while (!concurrentBagReplays.IsEmpty)
            {
                concurrentBagReplays.TryTake(out Replay someItem);
            }
            gridList.Clear();

            Parallel.ForEach(files, file =>
            {
                concurrentBagReplays.Add(Replay.Deserialize(file));

            });

            //foreach (var file in files)
            //{
            //    gridList.Add(Replay.Deserialize(file));

            //}

            while (!concurrentBagReplays.IsEmpty)
            {
                if (concurrentBagReplays.TryTake(out var replay))
                {
                    Debug.WriteLine(replay.ToDebugString());
                    gridList.Add(replay);
                }
                else
                    Debug.WriteLine("TryTake failed for non-empty bag");
            }

            gridControl1.DataSource = gridList;
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void exportToJSONToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var exportCount = 0;
            Parallel.ForEach(gridList, replay =>
            {
                var id = GetReplayPropertyValueByName(replay, "Id");
                var path = Path.Combine(textBoxReplayPath.Text, $"{id}.json");
                var serializer = new JsonSerializer();
                var jsonData = serializer.Serialize(replay, false, true);
                File.WriteAllText(path, jsonData);
                exportCount++;

            });
            MessageBox.Show($"Exported {exportCount} .json files.");
        }

        private static string GetReplayPropertyValueByName(Replay replay, string propertyName)
        {
            return replay.Properties.Values.FirstOrDefault(x => x.Name == propertyName)?.Value.ToString();
        }
    }
}
