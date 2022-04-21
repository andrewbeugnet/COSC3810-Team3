import React, { useState } from "react";
import { useKeenSlider } from "keen-slider/react";
import "keen-slider/keen-slider.min.css";

import Card from "@material-ui/core/Card";
import CardContent from "@material-ui/core/CardContent";
import Typography from "@material-ui/core/Typography";

import groundTemp from "../src/images/groundtemp.png";
import airTemp from "../src/images/airtemp.png";
import windSpeed from "../src/images/windspeed.png";
import rainTotal from "../src/images/raintotal.png";

export default function Layout({ children }) {
  const [currentSlide, setCurrentSlide] = useState(0);
  const [loaded, setLoaded] = useState(false);
  const [sliderRef, instanceRef] = useKeenSlider({
    initial: 0,
    slideChanged(slider) {
      setCurrentSlide(slider.track.details.rel);
    },
    created() {
      setLoaded(true);
    },
  });

  return (
    <>
      <div className="navigation-wrapper">
        
        <div 
        ref={sliderRef} 
        className="keen-slider"
        >
          <div 
          className="keen-slider__slide number-slide1"
          >
            <div>
              Location 1
            </div>
            
            <Card className="card-t bottom-left" style={{ width: "40%", height: "40%", right: "15%", backgroundColor: 'rgba(239, 242, 225, 0.4)', }}>
            <CardContent>
                  <div className = "tempIcon">
                  <img className="imgSize" src={windSpeed} />
                  </div>
                  <Typography
                    style={{ fontSize: 40 }}
                    color="black"
                    gutterBottom
                  >
                    Wind Speed
                  </Typography>
                  <Typography className = "wind-speed average" variant="h5" component="h2">
                    Average: <b>## °</b>
                  </Typography>
                  <Typography className = "wind-speed min" variant="h5" component="h2">
                    Minimum: <b>## °</b>
                  </Typography>
                  <Typography className = "wind-speed max" variant="h5" component="h2">
                    Maximum: <b>## °</b>
                  </Typography>
                </CardContent>
                
            </Card>

            <Card className = "card-t top-left" style={{ width: "40%", height: "40%", right: "50%", backgroundColor: 'rgba(239, 242, 225, 0.4)', }}>
                <CardContent>
                  <div className = "tempIcon">
                  <img className="imgSize" src={groundTemp} />
                  </div>
                  <Typography
                    style={{ fontSize: 40 }}
                    color="black"
                    gutterBottom
                  >
                    Ground Temperature
                  </Typography>
                  <Typography className = "ground-temp average" variant="h5" component="h2">
                    Average: <b>## °</b>
                  </Typography>
                  <Typography className = "ground-temp min" variant="h5" component="h2">
                    Minimum: <b>## °</b>
                  </Typography>
                  <Typography className = "ground-temp max" variant="h5" component="h2">
                    Maximum: <b>## °</b>
                  </Typography>
                </CardContent>
                
            </Card>

            <Card className = "card-t top-right" style={{ width: "40%", height: "40%", boxSizing: "2%", backgroundColor: 'rgba(239, 242, 225, 0.4)', }}>
              <CardContent>
                  <div className = "tempIcon">
                  <img className="imgSize" src={airTemp} />
                  </div>
                  <Typography
                    style={{ fontSize: 40 }}
                    color="black"
                    gutterBottom
                  >
                    Air Temperature
                  </Typography>
                  <Typography className = "ground-temp average" variant="h5" component="h2">
                    Average: <b>## °</b>
                  </Typography>
                  <Typography className = "ground-temp min" variant="h5" component="h2">
                    Minimum: <b>## °</b>
                  </Typography>
                  <Typography className = "ground-temp max" variant="h5" component="h2">
                    Maximum: <b>## °</b>
                  </Typography>
                </CardContent>
                
            </Card>
            <Card className = "card-t bottom-right1" style={{ width: "18%", height: "40%", boxSizing: "2%", backgroundColor: 'rgba(239, 242, 225, 0.4)', }}>
                <CardContent>
                  <Typography
                    style={{ fontSize: 40 }}
                    color="black"
                    gutterBottom
                  >
                    <div className="wind-direction"> <b>NE</b> </div>
                    <div className="wind-direction-title">Wind Direction</div>
                    
                  </Typography>
                </CardContent>
                
            </Card>
            <Card className = "card-t bottom-right2" style={{ width: "18%", height: "40%", boxSizing: "2%", backgroundColor: 'rgba(239, 242, 225, 0.4)', }}>
                <CardContent>
                  
                  <Typography
                    style={{ fontSize: 40 }}
                    color="black"
                    gutterBottom
                  >
                    <div className="rainfall-icon"> <img className="rainfall-image-size" src={rainTotal} /> </div>
                    <div className="rainfall-title">
                      Total Rain Fall
                    </div>
                  </Typography>
                  
                  
                </CardContent>
                
            </Card>

            {/* </div> */}
            
          
          
          </div>
          <div className="keen-slider__slide number-slide2">
          <div>
              Location 2
          </div>
          <Card className="card-t bottom-left" style={{ width: "40%", height: "40%", right: "15%", backgroundColor: 'rgba(239, 242, 225, 0.4)', }}>
                <CardContent>
                  <Typography
                    style={{ fontSize: 40 }}
                    color="black"
                    gutterBottom
                  >
                    Wind Speed
                  </Typography>
                  <Typography variant="h5" component="h2">
                    Average:
                  </Typography>
                  <Typography variant="h5" component="h2">
                    Minimum:
                  </Typography>
                  <Typography variant="h5" component="h2">
                    Maximum:
                  </Typography>
                </CardContent>
                
            </Card>

            <Card className = "card-t top-left" style={{ width: "40%", height: "40%", right: "50%", backgroundColor: 'rgba(239, 242, 225, 0.4)', }}>
                <CardContent>
                  <Typography
                    style={{ fontSize: 40 }}
                    color="black"
                    gutterBottom
                  >
                    Ground Temperature
                  </Typography>
                  <Typography variant="h5" component="h2">
                    Average:
                  </Typography>
                  <Typography variant="h5" component="h2">
                    Minimum:
                  </Typography>
                  <Typography variant="h5" component="h2">
                    Maximum:
                  </Typography>
                </CardContent>
                
            </Card>

            <Card className = "card-t top-right" style={{ width: "40%", height: "40%", boxSizing: "2%", backgroundColor: 'rgba(239, 242, 225, 0.4)', }}>
                <CardContent>
                  <Typography
                    style={{ fontSize: 40 }}
                    color="black"
                    gutterBottom
                  >
                    Air Temperature
                  </Typography>
                  <Typography variant="h5" component="h2">
                    Average:
                  </Typography>
                  <Typography variant="h5" component="h2">
                    Minimum:
                  </Typography>
                  <Typography variant="h5" component="h2">
                    Maximum:
                  </Typography>
                </CardContent>
                
            </Card>
            <Card className = "card-t bottom-right1" style={{ width: "18%", height: "40%", boxSizing: "2%", backgroundColor: 'rgba(239, 242, 225, 0.4)', }}>
                <CardContent>
                  <Typography
                    style={{ fontSize: 40 }}
                    color="black"
                    gutterBottom
                  >
                    Wind Direction
                  </Typography>
                </CardContent>
                
            </Card>
            <Card className = "card-t bottom-right2" style={{ width: "18%", height: "40%", boxSizing: "2%", backgroundColor: 'rgba(239, 242, 225, 0.4)', }}>
                <CardContent>
                  <Typography
                    style={{ fontSize: 40 }}
                    color="black"
                    gutterBottom
                  >
                    Total Rain Fall
                  </Typography>
                  <Typography variant="h5" component="h2">
                    Average:
                  </Typography>
                  <Typography variant="h5" component="h2">
                    Minimum:
                  </Typography>
                  <Typography variant="h5" component="h2">
                    Maximum:
                  </Typography>
                </CardContent>
                
            </Card>
          </div>
          <div className="keen-slider__slide number-slide3">
          <div>
              Location 3
            </div>
          </div>
          <div className="keen-slider__slide number-slide4">
          <div>
              Location 4
            </div>
          
          </div>
          <div className="keen-slider__slide number-slide5">
          <div>
              Location 5
            </div>
          

          </div>
          <div className="keen-slider__slide number-slide6">
          <div>
              Location 6
            </div>
        
          </div>
        </div>
        {loaded && instanceRef.current && (
          <>
            <Arrow
              left
              onClick={(e) =>
                e.stopPropagation() || instanceRef.current?.prev()
              }
              disabled={currentSlide === 0}
            />

            <Arrow
              onClick={(e) =>
                e.stopPropagation() || instanceRef.current?.next()
              }
              disabled={
                currentSlide ===
                instanceRef.current.track.details.slides.length - 1
              }
            />
          </>
        )}
      </div>
      {loaded && instanceRef.current && (
        <div className="dots">
          {[
            ...Array(instanceRef.current.track.details.slides.length).keys(),
          ].map((idx) => {
            return (
              <button
                key={idx}
                onClick={() => {
                  instanceRef.current?.moveToIdx(idx);
                }}
                className={"dot" + (currentSlide === idx ? " active" : "")}
              ></button>
            );
          })}
        </div>
      )}
    </>
  );
}

function Arrow(props) {
  const disabeld = props.disabled ? " arrow--disabled" : "";
  return (
    <svg
      onClick={props.onClick}
      className={`arrow ${
        props.left ? "arrow--left" : "arrow--right"
      } ${disabeld}`}
      xmlns="http://www.w3.org/2000/svg"
      viewBox="0 0 24 24"
    >
      {props.left && (
        
        <path d="M16.67 0l2.83 2.829-9.339 9.175 9.339 9.167-2.83 2.829-12.17-11.996z" />
      )}
      {!props.left && (
        <path d="M5 3l3.057-3 11.943 12-11.943 12-3.057-3 9-9z" />
      )}
    </svg>
  );
}
