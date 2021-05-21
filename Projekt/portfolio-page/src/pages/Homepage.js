import React, { Component } from "react";

import { Button } from "react-bootstrap";
import fx from "fireworks";

export default class Homepage extends Component {
  constructor(props) {
    super(props);
    this.escFunction = this.escFunction.bind(this);
  }
  escFunction(event) {
    if (event.keyCode === 80) {
      console.log();
      fx({
        x: Math.random() * window.innerWidth - 200,
        y: (Math.random() * window.innerWidth) / 4,
        colors: ["#E31B6D", "#FFc300", "#E81224"],
        count: 20,
      });
    }
  }
  componentDidMount() {
    document.addEventListener("keydown", this.escFunction, false);
  }
  componentWillUnmount() {
    document.removeEventListener("keydown", this.escFunction, false);
  }

  render() {
    return (
      <>
        <br />

        <div className="center-full">
          <h1>
            Hello friend, I'm <strong className="title">Philip</strong>.
          </h1>
          <h2>I am student and an aspiring developer with passion for open source ❤️</h2>
          <Button className="button-homepage" variant="dark" href="/about-me">
            about-me
          </Button>{" "}
          <Button className="button-homepage" variant="dark" href="/projects">
            projects
          </Button>{" "}
          <Button className="button-homepage " variant="dark" href="/contact">
            contact
          </Button>
        </div>
      </>
    );
  }
}
