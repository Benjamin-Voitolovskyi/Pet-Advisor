using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StaticExpertSystem
{
    public partial class Form1 : Form
    {
        private readonly string m_recommendation = "Based on your information, ";
        private readonly Size m_pictureSize = new(Constants.imageSize, Constants.imageSize);
        private PictureBox[] m_pictures;
        private Dictionary<string, Image> m_petToImage;

        public Form1()
        {
            InitializeComponent();

            m_petToImage = new();
            foreach (var pet in Constants.pets)
            {
                m_petToImage.Add(pet, Utils.Resize(Utils.GetImage(pet), new Size(Constants.imageSize, Constants.imageSize)));
            }
        }

        private void submitButton_Click(object sender, EventArgs e)
        {
            List<Rule> rules = new();
            rules.Add(new GoalRule(goalBox.Text));
            rules.Add(new LifeStyleRule(lifestyleBox.Checked));
            rules.Add(new AllergyRule(allergyBox.Checked));
            rules.Add(new NoFreeTimeRule(!timeBox.Checked));
            rules.Add(new LittleKidsRule(littleKidsBox.Checked));
            rules.Add(new LittleSpaceRule(!spaceBox.Checked));
            rules.Add(new SizeRule(sizeBox.Text));

            string[] recommendations;
            try
            {
                recommendations = RuleRunner.Run(rules);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }
            
            resultLabel.Text = m_recommendation;
            resultLabel.Text += recommendations.Length switch
            {
                0 => "there are no recommended pets.",
                1 => "the recommended pet is ",
                _ => "the recommended pets are "
            };

            if (m_pictures is not null)
            {
                for (int i = 0; i < m_pictures.Length; ++i)
                    Controls.Remove(m_pictures[i]);
            }

            int x = Constants.leftPadding;
            m_pictures = new PictureBox[recommendations.Length];

            for (int i = 0; i < recommendations.Length; ++i)
            {
                resultLabel.Text += recommendations[i];
                resultLabel.Text += i < recommendations.Length - 1 ? ", " : ".";
                m_pictures[i] = new()
                {
                    Size = m_petToImage[recommendations[i]].Size,
                    Location = new Point(x, Constants.yImage),
                    Image = m_petToImage[recommendations[i]],
                };
                Controls.Add(m_pictures[i]);

                x += m_petToImage[recommendations[i]].Width + Constants.paddingBetweenImages;
            }
        }
    }
}
