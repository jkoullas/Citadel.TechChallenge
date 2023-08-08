import { useState, useRef } from "react";
import "./css/site.css";

export const App = ()  => {

    const [responseName, setMessage] = useState("");
    const url = "https://localhost:7128/api/user-detail";
    const textboxName = useRef(null);

    const submitName = async (name) => {

        if(name == null || name.trim().length === 0)
        {
            setMessage("Please enter a name");
            return;
        }

        await fetch(url, {
        method: 'POST',
        body: JSON.stringify({
            name: name,
        }),
        headers: {
            'Content-type': 'application/json; charset=UTF-8',
        },
        })
        .then((response) => response.text())
        .then((data) => {
            setMessage(data);
        })
        .catch((err) => {
        console.log(err.message);
        });
    };

    const onClickHandler = async () => {
        await submitName(textboxName.current.value);
    }

    return <div  className="container">

            <h1 className="row-margin">Citadel Group Technical Challenge </h1>
            <h4 className="row-margin">You must now hire John Koullas!</h4>
            <hr/>
            <div className="row row-margin">
                <div className="col">
                    Please enter your name
                </div>
            </div>
            <div className="row row-margin">
                <div className="col">
                    <input type="text" id="userDetails" className="form-control" ref={textboxName} />
                </div>
            </div>
            <div className="row row-margin">
                <div className="col">
                    <button id="submitButton" className="btn btn-primary" onClick={onClickHandler} > Submit </button>
                </div>
            </div>
            
            <div className="row row-margin">
                <div className="col">
                    <label id = "outputLabel" className="thank-you">{responseName}</label>
                </div>
            </div>

        </div>;
}